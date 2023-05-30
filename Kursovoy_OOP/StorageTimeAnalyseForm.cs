using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoy_OOP
{
    public partial class StorageTimeAnalyseForm : Form
    {
        const string FILE_PRODUCTS = "Products.json";

        public StorageTimeAnalyseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Анализ сроков хранения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void StorageTimeAnalyseForm_Load(object sender, EventArgs e)
        {
            int shortTime = 0, medianTime = 0, longTime = 0;
            var products = await ReadFromFile<Product>(FILE_PRODUCTS);
            foreach (var p in products)
            {
                if (p.StorageTime < 180) shortTime++;
                else if (p.StorageTime < 366) medianTime++;
                else longTime++;
            }

            textBox1.Text = shortTime.ToString();
            textBox2.Text = medianTime.ToString();
            textBox3.Text = longTime.ToString();
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

        /// <summary>
        /// Закрытие текущей формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
