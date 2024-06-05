using System;

class Program
{
    static void Main(string[] args)
    {
        //Order 1
        Address address1 = new Address("2A DE OBREGON 140 ALTOS", "Hermosillo", "Sonora", "Mexico");
        Customer customer1 = new Customer("Cristal Marisela Gonzalez", address1);
        List<Product> productsList1 = new List<Product>();

        Product p1001 = new Product("Graphing Calculator", "GC200", 65.99, 1);
        Product p1002 = new Product("Notebook", "NB50", 3.60, 5);
        Product p1003 = new Product("Gel pens", "GP08", 5.28, 8);
        Product p1004 = new Product("Permanent Marker", "PM05", 2.99, 3);

        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);
        productsList1.Add(p1004);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------");

        // Order 2
        Address address2 = new Address("840 River Crest Court", "Louisville", "KY", "USA");
        Customer customer2 = new Customer("Wellington Paucek", address2);
        List<Product> productsList2 = new List<Product>();

        Product p2001 = new Product("Highlighter set", "HLSET", 8.99, 2);
        Product p2002 = new Product("Scientific Calculator", "SCC1000", 12.50, 1);
        Product p2003 = new Product("Index Cards", "IC100", 1.75, 2);
        Product p2004 = new Product("Math notebook", "MN50", 2.99, 4);

        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);
        productsList2.Add(p2004);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------");

        // Order 3
        Address address3 = new Address("22618 South Figueroa Street", "Carson", "CA", "USA");
        Customer customer3 = new Customer("Ulises Simonis", address3);
        List<Product> productsList3 = new List<Product>();

        Product p3001 = new Product("Watercolor Paint Set", "WPSET", 28.99 , 1);
        Product p3002 = new Product("Watercolor Brush Set", "WBSET", 25.50, 2);
        Product p3003 = new Product("Watercolor Sketchbook", "WS500", 30.99, 1);

        productsList3.Add(p3001);
        productsList3.Add(p3002);
        productsList3.Add(p3003);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------");
    }
}