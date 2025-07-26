// Product.cs
using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _price; // Price per unit
    private int _quantity; // Quantity in the order

    // Constructor to initialize product details
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Method to return the name of the product
    public string GetName()
    {
        return _name;
    }

    // Method to return the product ID
    public string GetProductId()
    {
        return _productId;
    }

    // Method to compute the total cost for this specific product (price * quantity)
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}