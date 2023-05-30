using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoy_OOP
{
    public partial class SalesReportForm : Form
    {
        const string FILE_SALES = "Sales.json";

        public SalesReportForm()
        {
            Task.Run(() => File.Open(FILE_SALES, FileMode.OpenOrCreate).Close());
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка данных о продажах из базы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void SalesReportForm_Load(object sender, EventArgs e)
        {
            salesReportTable.AllowUserToAddRows = false;
            if (File.Exists(FILE_SALES))
            {
                var sales = await ReadFromFile<Sale>(FILE_SALES);

                if (sales != null)
                    for (int i = 0; i < sales.Count; i++)
                    {
                        salesReportTable.Rows.Add();
                        salesReportTable.Rows[i].Cells[0].Value = sales[i].SaleDate;
                        salesReportTable.Rows[i].Cells[1].Value = sales[i].SaleTime;
                        salesReportTable.Rows[i].Cells[2].Value = sales[i].SerialNumber;
                        salesReportTable.Rows[i].Cells[3].Value = sales[i].Name;
                        salesReportTable.Rows[i].Cells[4].Value = sales[i].Manufacturer;
                    }
                if (salesReportTable.Rows.Count > 0)
                    salesReportTable.Rows[0].Selected = false;
            }
            
        }

        /// <summary>
        /// Удаление записи из базы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void DeleteSaleButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = -1;
            for (int i = 0; i < salesReportTable.Rows.Count; i++)
            {
                if (salesReportTable.Rows[i].Selected)
                {
                    selectedRowIndex = i;
                    var sales = await ReadFromFile<Sale>(FILE_SALES);

                    string saleDate = salesReportTable.Rows[i].Cells[0].Value.ToString();
                    string saleTime = salesReportTable.Rows[i].Cells[1].Value.ToString();
                    string serialNumber = salesReportTable.Rows[i].Cells[2].Value.ToString();
                    string name = salesReportTable.Rows[i].Cells[3].Value.ToString();
                    string manufacturer = salesReportTable.Rows[i].Cells[4].Value.ToString();

                    foreach (var s in sales)
                    {
                        if (s.SaleDate == saleDate &&
                            s.SaleTime == saleTime &&
                            s.SerialNumber == serialNumber &&
                            s.Name == name &&
                            s.Manufacturer == manufacturer)
                        {
                            sales.Remove(s);
                            break;
                        }
                    }

                    
                    salesReportTable.Rows.Remove(salesReportTable.Rows[selectedRowIndex]);
                    salesReportTable.Refresh();
                    MessageBox.Show($"Сведения о продаже детали '{name}' удалены из базы",
                        "Удаление записи", 0, MessageBoxIcon.Information);
                    await WriteToFile(sales, FILE_SALES);
                    break;
                }
            }

            if (selectedRowIndex < 0)
                MessageBox.Show("Выберете соответствующую запись!",
                    "Удаление записи", 0, MessageBoxIcon.Information);

        }

        /// <summary>
        /// Очистка базы продаж
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void ClearSalesButton_Click(object sender, EventArgs e)
        {
            if (salesReportTable.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите очистить базу?",
                    "Очистить все", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    while (salesReportTable.Rows.Count > 0)
                        salesReportTable.Rows.Remove(salesReportTable.Rows[0]);
                    salesReportTable.Refresh();

                    var sales = await ReadFromFile<Sale>(FILE_SALES);
                    sales.Clear();
                    
                    await WriteToFile(sales, FILE_SALES);
                    MessageBox.Show("База успешно очищена",
                        "Очистить все", 0, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("База пуста!",
                    "Очистить все", 0, MessageBoxIcon.Information);

        }

        /// <summary>
        /// Закрытие текущей формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToMainFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Запись в файл JSON
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="FILE_NAME"></param>
        /// <returns></returns>
        async public Task WriteToFile<T>(List<T> data, string FILE_NAME)
        {
            using (var streamWriter = new StreamWriter(FILE_NAME, false))
            {
                await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
            }
        }

        /// <summary>
        /// Чтение из файла JSON
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="FILE_NAME"></param>
        /// <returns></returns>
        async public Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
            }
        }
    }
}
