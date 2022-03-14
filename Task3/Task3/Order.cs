using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Order
    {
        public Product Product { get; set; }
        public DateTimeOffset PlacedDateTimeOffset { get; set; }
        public DateTime ExpectedDeliveryDateTime { get; set; }
        public DateTime ActualDeliveryDateTime { get; set; }

        public Order(Product product, DateTimeOffset placedDateTimeOffset, 
            DateTime expectedDeliveryDateTime, DateTime actualDeliveryDateTime)
        { 
            Product = product;
            PlacedDateTimeOffset = placedDateTimeOffset;
            ExpectedDeliveryDateTime = expectedDeliveryDateTime;
            ActualDeliveryDateTime = actualDeliveryDateTime;
        }

        public override string ToString()
        {
            return "Order on product: " + Product.Name +
                "\nWas placed on: " + PlacedDateTimeOffset +
                "\nWas expected to be delivered on: " + ExpectedDeliveryDateTime +
                "\nWas delivered on:" + ActualDeliveryDateTime;
        }
    }
}
