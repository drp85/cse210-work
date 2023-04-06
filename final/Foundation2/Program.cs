using System;

class Program 
{
    static void Main(string[] args) 
    {
        Console.Clear();

        Product p1 = new Product("Apple", "01", 10, 2);
        Product p2 = new Product("Window", "02", 20, 1);
        Product p3 = new Product("House", "03", 200, 1);
        Product p4 = new Product("Car", "04", 122, 4);


        Address a1 = new Address("14664 Apple Rd", "Banana Castle", "MI", "USA");
        Customer c1 = new Customer("Gregorith Henson", a1);
        Order o1 = new Order(c1);
        o1.AddProduct(p1);
        o1.AddProduct(p2);


        Address a2 = new Address("132 S 1st W", "RegularBurg", "DF", "Brazil");
        Customer c2 = new Customer("Johnny Stewy", a2);
        Order o2 = new Order(c2);
        o2.AddProduct(p2);

        Address a3 = new Address("1111 1st Primary Roadway", "Onederland","DC","USA");
        Customer c3 = new Customer("Incident Initial", a3);
        Order o3 = new Order(c3);
        o3.AddProduct(p4);
        o3.AddProduct(p3);
        o3.AddProduct(p2);


        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"Total: {o1.GetTotal():C}");

        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"Total: {o2.GetTotal():C}");

        Console.ForegroundColor = ConsoleColor.Magenta;

        Console.WriteLine(o3.GetPackingLabel());
        Console.WriteLine(o3.GetShippingLabel());
        Console.WriteLine($"Total: {o3.GetTotal():C}");

        Console.ResetColor();
        
        Console.WriteLine("\nPress Enter to end the program.");
        Console.ReadLine();
    }
}