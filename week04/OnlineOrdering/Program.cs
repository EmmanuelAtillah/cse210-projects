class Program
{
    static void Main(string[] args)
    {
     
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Keyboard", "K101", 29.99, 2));
        order1.AddProduct(new Product("Mouse", "M404", 19.99, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}\n");

      
        Address address2 = new Address("5 Downing Street", "London", "London", "UK");
        Customer customer2 = new Customer("Bob Johnson", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Webcam", "W303", 49.99, 1));
        order2.AddProduct(new Product("Microphone", "M202", 89.99, 1));
        order2.AddProduct(new Product("Tripod", "T909", 24.99, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }}