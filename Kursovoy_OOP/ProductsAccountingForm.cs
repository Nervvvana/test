using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoy_OOP
{
    public partial class ProductsAccountingForm : Form
    {
        const string FILE_PRODUCTS = "Products.json";
        const string FILE_SALES = "Sales.json";

        public ProductsAccountingForm()
        {
            Task.Run(() => File.Open(FILE_PRODUCTS, FileMode.OpenOrCreate).Close());
            InitializeComponent();
        }

        /// <summary>
        /// Заполнение таблицы данными из базы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void ProductsAccountingForm_Load(object sender, EventArgs e)
        {
            productsTable.AllowUserToAddRows = false;
            if (File.Exists(FILE_PRODUCTS))
            {
                var products = await ReadFromFile<Product>(FILE_PRODUCTS);
                totalCountTextBox.Text = products.Count.ToString();

                if (products != null)
                    for (int i = 0; i < products.Count; i++)
                    {
                        productsTable.Rows.Add();
                        productsTable.Rows[i].Cells[0].Value = products[i].SerialNumber;
                        productsTable.Rows[i].Cells[1].Value = products[i].Name;
                        productsTable.Rows[i].Cells[2].Value = products[i].Manufacturer;
                        productsTable.Rows[i].Cells[3].Value = products[i].Count;
                        productsTable.Rows[i].Cells[4].Value = products[i].StorageTime;
                        productsTable.Rows[i].Cells[5].Value = products[i].Price;
                    }
                if (productsTable.Rows.Count > 0)
                    productsTable.Rows[0].Selected = false;
            }
            
        }

        /// <summary>
        /// Открытие формы поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            new SearchProductForm().ShowDialog();
        }

        /// <summary>
        /// Добавление товара в базу продаж
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void SellProductButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = -1;
            for (int i = 0; i < productsTable.Rows.Count; i++)
            {
                if (productsTable.Rows[i].Selected)
                {
                    selectedRowIndex = i;
                    if ((int)productsTable.Rows[i].Cells[3].Value > 0)
                    {
                        var sales = await ReadFromFile<Sale>(FILE_SALES);

                        DateTime dt = DateTime.Now;
                        string currentDate = "";
                        if (dt.Day < 10) currentDate += "0" + dt.Day + ".";
                        else currentDate += dt.Day + ".";
                        if (dt.Month < 10) currentDate += "0" + dt.Month + ".";
                        else currentDate += dt.Month + ".";
                        currentDate += dt.Year;

                        string currentTime = "";
                        if (dt.Hour < 10) currentTime += "0" + dt.Hour + ":";
                        else currentTime += dt.Hour + ":";
                        if (dt.Minute < 10) currentTime += "0" + dt.Minute + ":";
                        else currentTime += dt.Minute + ":";
                        if (dt.Second < 10) currentTime += "0" + dt.Second;
                        else currentTime += dt.Second;

                        string saleDate = currentDate;
                        string saleTime = currentTime;
                        string serialNumber = productsTable.Rows[i].Cells[0].Value.ToString();
                        string name = productsTable.Rows[i].Cells[1].Value.ToString();
                        string manufacturer = productsTable.Rows[i].Cells[2].Value.ToString();

                        Sale newSale = new Sale(
                            saleDate,
                            saleTime,
                            serialNumber,
                            name,
                            manufacturer
                        );
                        sales.Add(newSale);
                        MessageBox.Show($"Деталь '{name}' успешно продана",
                            "Продажа детали", 0, MessageBoxIcon.Information);
                        await WriteToFile(sales, FILE_SALES);


                        var products = await ReadFromFile<Product>(FILE_PRODUCTS);
                        foreach (var p in products)
                        {
                            if (p.SerialNumber == serialNumber &&
                                p.Name == name &&
                                p.Manufacturer == manufacturer)
                            {
                                p.Count = (int)productsTable.Rows[i].Cells[3].Value - 1;
                                productsTable.Rows[i].Cells[3].Value = p.Count;
                                break;
                            }
                        }
                        await WriteToFile(products, FILE_PRODUCTS);
                        productsTable.Refresh();
                    }
                    else
                        MessageBox.Show($"Нет на складе!",
                            "Продажа детали", 0, MessageBoxIcon.Information);
                    
                    break;
                }
            }

            if (selectedRowIndex < 0)
                MessageBox.Show("Выберете соответствующую запись!",
                    "Удаление записи", 0, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Открытие формы редактирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void EditProductButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = -1;
            for (int i = 0; i < productsTable.Rows.Count; i++)
            {
                if (productsTable.Rows[i].Selected)
                {
                    selectedRowIndex = i;

                    Product currentProduct = new Product(
                        productsTable.Rows[i].Cells[0].Value.ToString(),
                        productsTable.Rows[i].Cells[1].Value.ToString(),
                        productsTable.Rows[i].Cells[2].Value.ToString(),
                        (int)productsTable.Rows[i].Cells[3].Value,
                        (int)productsTable.Rows[i].Cells[4].Value,
                        (int)productsTable.Rows[i].Cells[5].Value
                    );
                    EditProductForm.NewSerialNumber = currentProduct.SerialNumber;
                    EditProductForm.NewName = currentProduct.Name;
                    EditProductForm.NewManufacturer = currentProduct.Manufacturer;
                    EditProductForm.NewCount = currentProduct.Count;
                    EditProductForm.NewStorageTime = currentProduct.StorageTime;
                    EditProductForm.NewPrice = currentProduct.Price;

                    var products = await ReadFromFile<Product>(FILE_PRODUCTS);
                    foreach (var p in products)
                    {
                        if (p.SerialNumber == currentProduct.SerialNumber &&
                            p.Name == currentProduct.Name &&
                            p.Manufacturer == currentProduct.Manufacturer)
                        {
                            
                            products.Remove(p);
                            break;
                        }
                    }
                    new EditProductForm().ShowDialog();
                    if (EditProductForm.inputIsCorrect)
                    {
                        currentProduct.SerialNumber = EditProductForm.NewSerialNumber;
                        currentProduct.Name = EditProductForm.NewName;
                        currentProduct.Manufacturer = EditProductForm.NewManufacturer;
                        currentProduct.Count = EditProductForm.NewCount;
                        currentProduct.StorageTime = EditProductForm.NewStorageTime;
                        currentProduct.Price = EditProductForm.NewPrice;
                    }
                    products.Add(currentProduct);
                    await WriteToFile(products, FILE_PRODUCTS);
                    productsTable.Rows[i].Cells[0].Value = currentProduct.SerialNumber;
                    productsTable.Rows[i].Cells[1].Value = currentProduct.Name;
                    productsTable.Rows[i].Cells[2].Value = currentProduct.Manufacturer;
                    productsTable.Rows[i].Cells[3].Value = currentProduct.Count;
                    productsTable.Rows[i].Cells[4].Value = currentProduct.StorageTime;
                    productsTable.Rows[i].Cells[5].Value = currentProduct.Price;
                    productsTable.Refresh();
                    productsTable.Rows[0].Selected = false;
                    break;
                }
            }


            if (selectedRowIndex < 0)
                MessageBox.Show("Выберете соответствующую деталь!",
                    "Удаление детали", 0, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Добавление нового товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void CreateProductButton_Click(object sender, EventArgs e)
        {
            new CreateProductForm().ShowDialog();

            string newSerialNumber = CreateProductForm.NewSerialNumber;
            string newName = CreateProductForm.NewName;
            string newManufacturer = CreateProductForm.NewManufacturer;
            int newCount = CreateProductForm.NewCount;
            int newStorageTime = CreateProductForm.NewStorageTime;
            int newPrice = CreateProductForm.NewPrice;

            if (!string.IsNullOrEmpty(newSerialNumber) &&
                !string.IsNullOrEmpty(newName) &&
                !string.IsNullOrEmpty(newManufacturer) &&
                newCount >= 0 &&
                newStorageTime >= 0 &&
                newPrice >= 0)
            {
                Product newProduct = new Product(
                    newSerialNumber,
                    newName,
                    newManufacturer,
                    newCount,
                    newStorageTime,
                    newPrice
                );

                var products = await ReadFromFile<Product>(FILE_PRODUCTS);
                foreach (var p in products)
                {
                    if (p.SerialNumber == newSerialNumber &&
                        p.Name == newName &&
                        p.Manufacturer == newManufacturer)
                    {
                        MessageBox.Show($"Деталь '{p.Name}' с серийным номером '{p.SerialNumber}'" +
                            $" от производителя'{p.Manufacturer}' уже есть в базе",
                            "Добавление детали", 0, MessageBoxIcon.Information);
                        return;
                    }
                }

                products.Add(newProduct);
                totalCountTextBox.Text = products.Count.ToString();

                await WriteToFile(products, FILE_PRODUCTS);

                productsTable.Rows.Add();
                productsTable.Rows[products.Count - 1].Cells[0].Value = newSerialNumber;
                productsTable.Rows[products.Count - 1].Cells[1].Value = newName;
                productsTable.Rows[products.Count - 1].Cells[2].Value = newManufacturer;
                productsTable.Rows[products.Count - 1].Cells[3].Value = newCount;
                productsTable.Rows[products.Count - 1].Cells[4].Value = newStorageTime;
                productsTable.Rows[products.Count - 1].Cells[5].Value = newPrice;
                productsTable.Rows[0].Selected = false;
            }
        }

        /// <summary>
        /// Открытие формы анализа сроков хранения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StorageTimeAnalyseButton_Click(object sender, EventArgs e)
        {
            new StorageTimeAnalyseForm().ShowDialog();
        }

        async private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = -1;
            for (int i = 0; i < productsTable.Rows.Count; i++)
            {
                if (productsTable.Rows[i].Selected)
                {
                    selectedRowIndex = i;
                    var products = await ReadFromFile<Product>(FILE_PRODUCTS);

                    string serialNumber = productsTable.Rows[i].Cells[0].Value.ToString();
                    string name = productsTable.Rows[i].Cells[1].Value.ToString();
                    string manufacturer = productsTable.Rows[i].Cells[2].Value.ToString();
                    int count = int.Parse(productsTable.Rows[i].Cells[3].Value.ToString());
                    int storageTime = int.Parse(productsTable.Rows[i].Cells[4].Value.ToString());
                    int price = int.Parse(productsTable.Rows[i].Cells[5].Value.ToString());

                    foreach (var p in products)
                    {
                        if (p.SerialNumber == serialNumber &&
                            p.Name == name &&
                            p.Manufacturer == manufacturer &&
                            p.Count == count &&
                            p.StorageTime == storageTime &&
                            p.Price == price)
                        {
                            products.Remove(p);
                            break;
                        }
                    }

                    totalCountTextBox.Text = products.Count.ToString();
                    productsTable.Rows.Remove(productsTable.Rows[selectedRowIndex]);
                    productsTable.Refresh();
                    if (productsTable.Rows.Count > 0)
                        productsTable.Rows[0].Selected = false;
                    MessageBox.Show($"Деталь '{name}' удалена из базы", "Удаление детали", 0,
                            MessageBoxIcon.Information);
                    await WriteToFile(products, FILE_PRODUCTS);
                    break;
                }
            }

            if (selectedRowIndex < 0)
                MessageBox.Show("Выберете соответствующую деталь!",
                    "Удаление детали", 0, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Очистка базы товаров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void ClearProductsButton_Click(object sender, EventArgs e)
        {
            if (productsTable.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите очистить базу?",
                    "Очистить все", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    while (productsTable.Rows.Count > 0)
                        productsTable.Rows.Remove(productsTable.Rows[0]);
                    productsTable.Refresh();

                    var products = await ReadFromFile<Product>(FILE_PRODUCTS);
                    products.Clear();
                    totalCountTextBox.Text = products.Count.ToString();
                    await WriteToFile(products, FILE_PRODUCTS);
                    MessageBox.Show("База успешно очищена",
                        "Очистить все", 0, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("База пуста!",
                    "Очистить все", 0, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Фильтр товаров в таблице по критериям
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterButton_Click(object sender, EventArgs e)
        {
            string value = filterTextBox.Text;
            int columnIndex = filterComboBox.SelectedIndex;
            bool hasVisibleRows = false;
            if (filterComboBox.SelectedIndex == -1 || filterComboBox.Text == "")
            {
                filterComboBox.Text = "";
                MessageBox.Show($"Выберите поле по которому будет поизводиться фильтрация", "Внимание",
                    0, MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataGridViewRow row in productsTable.Rows)
                {
                    if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString().Contains(value))
                    {
                        row.Visible = true;
                        hasVisibleRows = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                if (!hasVisibleRows)
                {
                    MessageBox.Show($"Полей с такими данными: {value} - нет!", "Внимание", 0, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Отображение таблицы после сброса фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterTextChanged_Click(object sender, EventArgs e)
        {
            if (filterTextBox.Text == "")
                foreach (DataGridViewRow row in productsTable.Rows)
                    row.Visible = true;
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
        async Task WriteToFile<T>(List<T> data, string FILE_NAME)
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
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
            }
        }
    }
}
