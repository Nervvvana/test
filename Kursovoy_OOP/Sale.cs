using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_OOP
{
    class Sale
    {
        /// <summary>
        /// Дата продажи
        /// </summary>
        public string SaleDate { get; set; }

        /// <summary>
        /// Время продажи
        /// </summary>
        public string SaleTime { get; set; }

        /// <summary>
        /// Серийный номер
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Производитель
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Конструктор класса Product
        /// </summary>
        /// <param name="saleDate">Дата продажи</param>
        /// <param name="saleTime">Время продажи</param>
        /// <param name="serialNumber">Серийный номер</param>
        /// <param name="name">Назвние</param>
        /// <param name="manufacturer">Производитель</param>
        public Sale(string saleDate, string saleTime, string serialNumber, string name, string manufacturer)
        {
            SaleDate = saleDate;
            SaleTime = saleTime;
            SerialNumber = serialNumber;
            Name = name;
            Manufacturer = manufacturer;
        }
    }
}
