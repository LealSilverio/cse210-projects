using System;

class Program
{
    static void Main(string[] args)
    {
        Customer person = new Customer();
        person.SetCustomer("John Smith");
        person.SetAddress("604 S 4th E", "Richmond", "ID", "USA");

        Customer customer = new Customer();
        customer.SetCustomer("Anna Oliveira");
        customer.SetAddress("Rua Emilio de Cavaliery - 203", "Sao Paulo", "SP", "BRA");

        Order o1 = new Order();
        Product p1o1 = new Product("Product 1", 127369);
        p1o1.SetPrice(50);
        p1o1.SetQuantity(2);

        Product p2o1 = new Product("Product 2", 405986);
        p2o1.SetPrice(10);
        p2o1.SetQuantity(5);

        var productsList = o1.GetList();
        productsList.Add(p1o1);
        productsList.Add(p2o1);

        List<int> priceList = new List<int>();
        priceList.Add(p1o1.calculatePrice());
        priceList.Add(p2o1.calculatePrice());

        Console.WriteLine("\tOrder 1\n");
        Console.WriteLine("Packing Labels:");
        o1.packingLabel();
        
        Console.WriteLine("Shipping Label:\n");
        Console.WriteLine(o1.shippingLabel(person));

        Console.WriteLine(string.Empty);
        Console.WriteLine($"Your total is: {o1.calculateTotal(person.livingInTheUS(), priceList)}");


        Order o2 = new Order();
        Product p1o2 = new Product("Product 1.2", 978243);
        p1o2.SetPrice(10);
        p1o2.SetQuantity(2);

        Product p2o2 = new Product("Product 2.2", 098642);
        p2o2.SetPrice(100);
        p2o2.SetQuantity(5);

        var productsList2 = o2.GetList();
        productsList2.Add(p1o2);
        productsList2.Add(p2o2);

        List<int> priceList2 = new List<int>();
        priceList2.Add(p1o2.calculatePrice());
        priceList2.Add(p2o2.calculatePrice());

        Console.WriteLine("\n\tOrder 2\n");
        Console.WriteLine("Packing Labels:");
        o2.packingLabel();
        
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(o2.shippingLabel(customer));

        Console.WriteLine(string.Empty);
        Console.WriteLine($"Your total is: {o2.calculateTotal(customer.livingInTheUS(), priceList2)}");
    }
}