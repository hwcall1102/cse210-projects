using System;

namespace Products
{
    public class Product
    {
        private string _productName{get; set;}
        private string _productId{get; set;}
        private double _price{get; set;}
        private int _quantity{get; set;}

        public Product (string name, string id, double price, int quantity)
        {
            _productName = name;
            _productId = id;
            _price = price;
            _quantity = quantity;
        }

        public double CalculatePrice()
        {
            return Math.Round((_price * _quantity), 2);
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"{_productName} ({_productId}) => Total: ${CalculatePrice()}");
        }
    }
}