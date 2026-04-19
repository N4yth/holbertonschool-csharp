using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public class Item : BaseClass
    {
        public string name { get; set; }

        public string description { get; set; }
        private float _price;
        public float price
        {
            get => _price;
            set => _price = (float)Math.Round(value, 2);
        }

        public List<string> tags { get; set; }

        public Item(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("name cannot be empty");

            this.name = name;
            description = "";
            tags = new List<string>();
            price = 0.0f;
        }
    }
}