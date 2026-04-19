using System;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        public string user_id { get; set; }
        public string item_id { get; set; }

        private int _quantity;
        public int quantity
        {
            get => _quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("quantity cannot be less than 0");

                _quantity = value;
            }
        }

        public Inventory(string user_id, string item_id, int quantity = 1)
        {
            if (string.IsNullOrWhiteSpace(user_id))
                throw new ArgumentException("user_id cannot be empty");

            if (string.IsNullOrWhiteSpace(item_id))
                throw new ArgumentException("item_id cannot be empty");

            this.user_id = user_id;
            this.item_id = item_id;
            this.quantity = quantity;
        }
    }
}