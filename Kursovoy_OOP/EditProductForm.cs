using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Kursovoy_OOP
{
    public partial class EditProductForm : Form
    {
        public static string NewSerialNumber = "";
        public static string NewName = "";
        public static string NewManufacturer = "";
        public static int NewCount = -1;
        public static int NewStorageTime = -1;
        public static int NewPrice = -1;
        public static bool inputIsCorrect = false;

        public EditProductForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка редактируемых данных в форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditProductForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = NewSerialNumber;
            textBox2.Text = NewName;
            textBox3.Text = NewManufacturer;
            textBox4.Text = NewCount.ToString();
            textBox5.Text = NewStorageTime.ToString();
            textBox6.Text = NewPrice.ToString();
        }

        /// <summary>
        /// Редактирование товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            inputIsCorrect = true;

            if (Regex.Match(textBox1.Text, "^[A-Za-z0-9]+$").Success)
            {
                NewSerialNumber = textBox1.Text;
                label7.Text = "";
            }
            else
            {
                label7.Text = "Допускаются только символы латиницы и цифры";
                inputIsCorrect = false;
            }

            if (Regex.Match(textBox2.Text, "^[A-Za-z0-9А-Яа-я\\s]+$").Success)
            {
                NewName = textBox2.Text;
                label8.Text = "";
            }
            else
            {
                label8.Text = "Допускаются только символы латиницы, кириллицы, пробела и цифры";
                inputIsCorrect = false;
            }

            if (Regex.Match(textBox3.Text, "^[A-Za-z0-9А-Яа-я\\s]+$").Success)
            {
                NewManufacturer = textBox3.Text;
                label9.Text = "";
            }
            else
            {
                label9.Text = "Допускаются только символы латиницы, кириллицы, пробела и цифры";
                inputIsCorrect = false;
            }

            if (int.TryParse(textBox4.Text, out NewCount) && NewCount >= 0)
                label10.Text = "";
            else
            {
                inputIsCorrect = false;
                label10.Text = "Допускаются только целые положительные числа";
            }

            if (int.TryParse(textBox5.Text, out NewStorageTime) && NewStorageTime >= 0)
                label11.Text = "";
            else
            {
                inputIsCorrect = false;
                label11.Text = "Допускаются только целые положительные числа";
            }

            if (int.TryParse(textBox6.Text, out NewPrice) && NewPrice >= 0)
                label12.Text = "";
            else
            {
                inputIsCorrect = false;
                label12.Text = "Допускаются только целые положительные числа";
            }

            if (inputIsCorrect) Close();
        }

        /// <summary>
        /// Закрытие текущей формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
