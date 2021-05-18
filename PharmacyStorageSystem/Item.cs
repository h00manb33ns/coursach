using System;

namespace PharmacyStorageSystem
{
    [Serializable]
    public class Item
    {
        public string name { get; set; }
        public double price { get; set; }
        public string creator { get; set; }

        public string storage { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"Наименование: {name} \n Цена: {price} \n Производитель: {creator}");
        }
    }
}