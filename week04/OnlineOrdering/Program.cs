using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
        // ORDER 1 - 
        

        Address address1 = new Address("123 Main Street", "Seattle","Washington", "USA");

        Customer customer1 = new Customer("Peter Biney",address1 );

        Product product1 = new Product( "Microphones","k1100",20.00,2);

        Product product2 = new Product("Cords","c2200",10.00,1);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        //  ORDER 2 
        
        Address address2 = new Address( "redemption valley street c9j45","Tema","Ghana","West Africa");

        Customer customer2 = new Customer("Akosua Adomaa",address2);

        Product product3 = new Product("Adapter","a3300",15.00,1);

        Product product4 = new Product("Batteries","w4400",5.00,2);

        Product product5 = new Product("USB Cable","U500",10.00,3);

        Order order2 = new Order(customer2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

    
        Console.WriteLine("ORDER 1");

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        // DISPLAY ORDER 2

        Console.WriteLine("ORDER 2");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}

    
