using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task3
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public double Price { get; set; }

        public Product(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            CultureInfo USCultureInfo = CultureInfo.GetCultureInfo("us-US");
            return "Product name: " + Name +
                "\nProduct price: " + Price.ToString("C", USCultureInfo);
        }
    }
}
