using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ProductRepository
    {
        public List<Product> Products;

        public ProductRepository()
        {
            Products = new List<Product>();
        }

        public void Add(Product product)
        { 
            Products.Add(product); 
        }

        public List<Product> getAll()
        {
            return Products;
        }
    }
}
