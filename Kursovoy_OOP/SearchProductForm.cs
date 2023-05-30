using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoy_OOP
{
    public partial class SearchProductForm : Form
    {
        const string FILE_PRODUCTS = "Products.json";

        public SearchProductForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверка введенных данных на корректность, поиск товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void SearchButton_Click(object sender, EventArgs e)
        {
            bool inputIsCorrect = true;

            if (Regex.Match(textBox1.Text, "^[A-Za-z0-9]+$").Success)
                label4.Text = "";
            else
            {
                label4.Text = "Допускаются только символы латиницы и цифры";
                inputIsCorrect = false;
            }

            if (Regex.Match(textBox2.Text, "^[A-Za-z0-9А-Яа-я\\s]+$").Success)
                label5.Text = "";
            else
            {
                label5.Text = "Допускаются только символы латиницы, кириллицы, пробела и цифры";
                inputIsCorrect = false;
            }

            if (Regex.Match(textBox3.Text, "^[A-Za-z0-9А-Яа-я\\s]+$").Success)
                label6.Text = "";
            else
            {
                label6.Text = "Допускаются только символы латиницы, кириллицы, пробела и цифры";
                inputIsCorrect = false;
            }

            if (inputIsCorrect)
            {
                var products = await ReadFromFile<Product>(FILE_PRODUCTS);
                var flag = true;
                foreach (var p in products)
                {
                    if (p.SerialNumber == textBox1.Text &&
                        p.Name == textBox2.Text &&
                        p.Manufacturer == textBox3.Text)
                    {
                        MessageBox.Show($"Серийный номер '{p.SerialNumber}' \n" +
                            $"Название детали '{p.Name}' \n" +
                            $"Производитель '{p.Manufacturer}' \n" +
                            $"Кол-во на складе {p.Count} \n" +
                            $"Срок хранения {p.StorageTime} д.\n" +
                            $"Цена {p.Price} руб.",
                            "Поиск детали", 0, MessageBoxIcon.Information);
                        flag = false;
                        break;
                    }
                }

                if (flag)
                    MessageBox.Show($"Деталь не найдена",
                            "Поиск детали", 0, MessageBoxIcon.Information);
            }
            
        }

        /// <summary>
        /// Закрытие текущей формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            Close();
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
