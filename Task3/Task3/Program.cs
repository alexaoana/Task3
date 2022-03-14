namespace Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product product1 = new Product("3Y115708", "    A fi utilizat inainte de: vezi pe ambalaj." +
                "    Acest produs este interzis copiilor cu varste sub 10 ani.    A se feri de contactul cu ochii", 15);
            Product product2 = new Product("3Y118906", "    Se recomanda consumarea inainte de: a se vedea pe ambalaj." +
                "    Acest produs este destinat in special copiilor.    Nu se recomanda adultilor", 20);
            Product product3 = new Product("2Y112389", "    Nu se accepta retururi.    A se spala la 30 de grade.    Marime:S(36)", 40);
            Product product4 = new Product("1Y340979", "    Va rugam sa urmariti instructiunile de utilizare." +
                "    Ambalajul este reciclabil.    Incurajam colectarea acestuia corespunzator", 22);

            ProductRepository productRepository = new ProductRepository();
            productRepository.Add(product1);
            productRepository.Add(product2);
            productRepository.Add(product3);
            productRepository.Add(product4);
            List<Product> products = productRepository.getAll();

            Console.WriteLine($"At {DateTime.Now} our shop has {products.Count} products available");
            Console.WriteLine();

            foreach (Product product in products)
            {
                if (product.Name.Contains("3Y"))
                    Console.WriteLine("This product is a medicine");
                if (product.Name.Contains("2Y"))
                    Console.WriteLine("This product is a piece of clothing");
                if (product.Name.Contains("1Y"))
                    Console.WriteLine("This product is in \"other\" category");
                Console.WriteLine(product.ToString());
                Console.WriteLine("Here are some usefull information about this product: ");
                string[] descriptions = product.Description.Split('.');
                foreach (string description in descriptions)
                    Console.WriteLine(description);
                Console.WriteLine();
            }

            Order order1 = new Order(product1, DateTimeOffset.Now, new DateTime(2022, 3, 15, 15, 0, 0), new DateTime(2022, 3, 15, 12, 0, 0));
            Order order2 = new Order(product2, new DateTimeOffset(new DateTime(2022, 3, 12, 0, 0, 0)),
                new DateTime(2022, 3, 19, 13, 30, 0), new DateTime(2022, 3, 20, 10, 0, 0));
            
            OrderRepository orderRepository = new OrderRepository();
            orderRepository.Add(order1);
            orderRepository.Add(order2);
            List<Order> orders = orderRepository.getAll();

            Console.WriteLine("You currently have {0} orders in our shop", orders.Count);
            Console.WriteLine();

            foreach (Order order in orders)
            {
                Console.WriteLine(order.ToString());
                TimeSpan delay = order.ExpectedDeliveryDateTime - order.ActualDeliveryDateTime;
                if (delay > new TimeSpan(0))
                    Console.WriteLine($"This order was delivered earlier with {delay} hours");
                else
                    Console.WriteLine($"This order was delivered later with {-delay} hours");
                Console.WriteLine();
            }
        }
    }
}
