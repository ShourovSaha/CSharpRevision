namespace LazyLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Customer customer = new Customer();

            Console.WriteLine(customer.CustomerName);

            foreach (var item in customer.Orders)
            {
                Console.WriteLine(item.OrderId);
            }

            Console.ReadKey();
        }
    }
}