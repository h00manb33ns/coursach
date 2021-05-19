using System;

namespace PharmacyStorageSystem
{
    /// <summary>
    /// Класс товара
    /// </summary>
    [Serializable]
    public class Item
    {
        public string name { get; set; }
        public double price { get; set; }
        public string creator { get; set; }
        public string storage { get; set; }
    }
}