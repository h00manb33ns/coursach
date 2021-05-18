using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace PharmacyStorageSystem
{
    [Serializable]
    public class Items
    {
        private static List<Item> items = new List<Item>();
        public static void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = File.Open(@"C:\Users\PC\AppData\Roaming" + "/player.dat", FileMode.Create);
            formatter.Serialize(file, items);
            file.Close();
        }

        public static void Load()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = File.Open(@"C:\Users\PC\AppData\Roaming" + "/player.dat", FileMode.Open);
            items = (List<Item>) formatter.Deserialize(file);
            file.Close();
        }

       
        public static void appendList(string name, double price, string creator, string storage)
        {
            Console.Clear();
            items.Add(new Item(){name = name, price = price, creator = creator, storage = storage});
            Save();
            Program.MenuO();
        }

        public static void showList()
        {
            Load();
            Console.Clear();
            if (items.Count == 0)
            {
                Console.WriteLine("Список пуст");
                Console.ReadKey();
                Program.MenuO();
            }
            int i = 1;
            foreach (var item in items)
            {
                Console.WriteLine(i+". Наименование: " + item.name + "  Производитель: " + item.creator + "  Цена: " + item.price +"Руб.");
                i++;
            }
            Console.WriteLine("Выберите товар чтобы узнать о нём поподробнее или нажмите 0 для выхода в меню.");

            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                Program.MenuO();
            }
            
            Console.WriteLine("Наименование: " + items[a-1].name + " \nПроизводитель: " + items[a-1].creator + 
                              "\nЦена: " + items[a-1].price + " Руб.\nУсловия хранения: " + items[a-1].storage);
            
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Program.MenuO();
        }

        public static void deleteItem()
        {
            Console.Clear();
            if (items.Count == 0)
            {
                Console.WriteLine("Список пуст");
                Console.ReadKey();
                Program.MenuO();
            }
            Console.Clear();
            Console.WriteLine("Выберите номер объекта для удаления: ");
            int i = 1;
            foreach (var item in items)
            {
                Console.WriteLine(i+". Наименование: " + item.name + "  Производитель: " + item.creator + "  Цена: " + item.price +"₽");
                i++;
            }
            string id = Console.ReadLine();
            if (Convert.ToInt32(id) - 1 > items.Count || Convert.ToInt32(id) - 1 < items.Count)
            {
                Console.Clear();
                Console.WriteLine("Вы ввели некорректное число");
                deleteItem();
            }
            items.RemoveAt(Convert.ToInt32(id)-1);
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Program.MenuO();
        }

        public static void countSum()
        {
            Console.Clear();
            if (items.Count == 0)
            {
                Console.WriteLine("Список пуст");
                Console.ReadKey();
                Program.MenuO();
            }
            double sum = 0;
            foreach (var item in items)
            {
                sum += item.price;
            }
            Console.WriteLine("Сумма всех товаров составляет: " +sum);
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Program.MenuO();
        }
    }
}