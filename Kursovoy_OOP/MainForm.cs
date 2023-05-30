using System;
using System.Windows.Forms;

namespace Kursovoy_OOP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            using (var authorInfo = new AuthorInfo())
            {
                authorInfo.ShowDialog();
            }
            InitializeComponent();
        }

        /// <summary>
        /// Запуск формы учета товаров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsAccountingButton_Click(object sender, EventArgs e)
        {
            new ProductsAccountingForm().ShowDialog();
        }

        /// <summary>
        /// Запуск формы отчета о продажах
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalesReportButtton_Click(object sender, EventArgs e)
        {
            new SalesReportForm().ShowDialog();
        }

        /// <summary>
        /// Закрытие приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
