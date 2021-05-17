using System;

namespace PharmacyStorageSystem
{
    public class Item
    {
        public string name;
        public float price;

        public void GetInfo()
        {
            Console.WriteLine($"Наименование: {name} \n Цена: {price}");
        }
    }
}