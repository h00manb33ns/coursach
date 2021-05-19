using System;
using System.ComponentModel.Design;

namespace PharmacyStorageSystem
{
    class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Items.Load();
            MenuO();
        }
        /// <summary>
        /// Метод вывода и навигации по меню
        /// </summary>
        public static void MenuO()
        {
            Console.Clear();
            //Items items = new Items();
            Console.WriteLine("Выберите пункт меню:\n" +
                              "1. Добавить товар на склад\n" +
                              "2. Посмотреть товары на складе\n" +
                              "3. Удалить товар со склада\n" +
                              "4. Посчитать стоимость всех товаров\n" +
                              "5. Выход");
            switch (Console.ReadLine())
            {
                
                case "1":
                    Console.WriteLine("Введите название товара: ");
                    string naming = Console.ReadLine();
                    Console.WriteLine("Введите цену товара: ");
                    string pricing = Console.ReadLine();
                    Console.WriteLine("Введите имя производителя: ");
                    string creating = Console.ReadLine();
                    Console.WriteLine("Введите условия хранения: ");
                    string storage = Console.ReadLine();
                    Items.appendList(naming, Convert.ToDouble(pricing), creating, storage);
                    break;
                case "2":
                    Items.showList();
                    break;
                case "3":
                    Items.deleteItem();
                    break;
                case "4":
                    Items.countSum();
                    break;
                case "5":
                    break;
                default:
                    MenuO();
                    break;
            }
        }
    }
}