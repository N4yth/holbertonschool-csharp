using System;

namespace InventoryLibrary
{
    public class User : BaseClass
    {
        public string name { get; set; }

        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("name cannot be empty");

            this.name = name;
        }
    }
}