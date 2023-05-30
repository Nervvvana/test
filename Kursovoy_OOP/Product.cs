using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_OOP
{
    class Product
    {
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
        /// Количество на складе
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Срок хранения (дней)
        /// </summary>
        public int StorageTime { get; set; }

        /// <summary>
        /// Цена (рублей)
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Конструктор класса Product
        /// </summary>
        /// <param name="serialNumber">Серийный номер</param>
        /// <param name="name">Назвние</param>
        /// <param name="manufacturer">Производитель</param>
        /// <param name="count">Количество на складе</param>
        /// <param name="storageTime">Срок хранения</param>
        /// <param name="price">Цена</param>
        public Product(string serialNumber, string name, string manufacturer, int count, int storageTime, int price)
        {
            SerialNumber = serialNumber;
            Name = name;
            Manufacturer = manufacturer;
            Count = count;
            StorageTime = storageTime;
            Price = price;
        }
    }
}
