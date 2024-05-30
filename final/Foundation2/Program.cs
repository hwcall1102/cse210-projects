using System;
using Products;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        //order 1
        Address a1 = new Address ("98 Pleasant Ave.", "Bristol", "CT", "USA");
        Customer c1 = new Customer("Nice Guy", a1);

        double o1ShippingCost = c1.GetShippingCost();

        Product o1Product1 = new Product("Fuji Apple", "4131", 0.25, 2);
        Product o1Product2 = new Product("Haas Avacado", "4225", 0.50, 4);

        Order o1 = new Order(c1);
        o1.AddProduct(o1Product1);
        o1.AddProduct(o1Product2);
        double o1Subtotal = o1.CalculateSubtotal();
        double o1Total = o1.CalculateTotal();

        o1.DisplayShippingLabel();
        Console.WriteLine();
        o1.DisplayPackingLabel();
        Console.WriteLine();
        o1.DisplayCosts(o1Subtotal, o1ShippingCost, o1Total);

        Console.WriteLine();

        Address a2 = new Address ("Rua Garcia de Orta", "Lisbon", "Lisbon", "Portugal");
        Customer c2 = new Customer("Joao Garcia", a2);

        double order2ShippingCost = c2.GetShippingCost();

        Product o2Product1 = new Product("Husked Coconut", "4260", 2.00, 5);
        Product o2Product2 = new Product("Red Mango", "4959", 1.00, 4);
        Product o2Product3 = new Product("Pineapple", "4029", 2.00, 2);

        Order o2 = new Order(c2);
        o2.AddProduct(o2Product1);
        o2.AddProduct(o2Product2);
        o2.AddProduct(o2Product3);
        double order2Subtotal = o2.CalculateSubtotal();
        double order2Total = o2.CalculateTotal();


        //display order 2
        o2.DisplayShippingLabel(); 
        Console.WriteLine();
        o2.DisplayPackingLabel();
        Console.WriteLine();
        o2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
    }
}