using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=========================================\n");

        //order 1
        Address address1 = new Address ("104 Pine Avenue", "San Diego", "CA", "USA");
        Customer customer1 = new Customer ("Brigham Young", address1);

        double order1ShippingCost = customer1.GetShippingCost();

        Product order1Product1 = new Product("Pineapple", "1031", 4.99, 3);
        Product order1Product2 = new Product("Dragon Fruit", "7054", 8.99, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        double order1Subtotal = order1.CalculateSubtotal();
        double order1Total = order1.CalculateTotal();

        order1.DisplayShippingLabel();
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayCosts(order1Subtotal, order1ShippingCost, order1Total);


        Console.WriteLine("\n========================================\n");

        //order 2
        Address address2 = new Address ("38 Masterline Street", "Woodridge", "QLD", "Australia");
        Customer customer2 = new Customer ("Johnny Cash", address2);

        double order2ShippingCost = customer2.GetShippingCost();

        Product order2Product1 = new Product("Mango", "7655", 3.99, 2);
        Product order2Product2 = new Product("Banana", "1911", 1.12, 7);
        Product order2Product3 = new Product("Pineapple", "1031", 4.99, 4);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.CalculateSubtotal();
        double order2Total = order2.CalculateTotal();

        order2.DisplayShippingLabel();
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
        
        Console.WriteLine("\n=========================================\n");
    }

}