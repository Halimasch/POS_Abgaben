using SHOP_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP_API.DAL
{
    public class ProductDatabase
    {
        private static ProductDatabase theInstance;

        public static ProductDatabase getInstance()
        {
            if(theInstance == null)
            {
                theInstance = new ProductDatabase();
            }
            return theInstance;
        }

        private List<Products> products = new List<Products>();

        private ProductDatabase()
        {
            products.Add(new Products(0, "Harry Otter", "erster", 1.20f, "sers"));
        }

        public List<Products> GetProducts()
        {
            return products;
        }

        public Products GetProductById(int id)
        {
            return products.Find(p => p.Id == id);
        }
    }
}
