using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP_API.Model
{
    public class Products
    {
        private int id;
        private string name;
        private string description;
        private float price;
        private string imageUrl;

        public Products(int id, string name, string description, float price, string imageUrl)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.imageUrl = imageUrl;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public float Price { get => price; set => price = value; }
        public string ImageUrl { get => imageUrl; set => imageUrl = value; }
    }
}
