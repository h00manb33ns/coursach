using System;
using System.ComponentModel.Design;

namespace PharmacyStorageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuO();

        }

        public static void MenuO()
        {
            Console.WriteLine("Выберите пункт меню:\n" +
                              "1. Добавить товар на склад\n" +
                              "2. Посмотреть товары на складе\n" +
                              "3. Удалить товар со склада\n" +
                              "4. Выход");
            switch (Console.ReadLine())
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    MenuO();
                    break;
            }
        }
    }
}