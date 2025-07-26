// Order.cs
using System;
using System.Collections.Generic; // Required for List

public class Order
{
    private List<Product> _products; // Order "has-a" a list of Products
    private Customer _customer;      // Order "has-a" a Customer

    // Constructor to initialize the order with a customer and an empty product list
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total cost of the order including shipping
    public double GetTotalCost()
    {
        double productsTotal = 0;
        foreach (Product product in _products)
        {
            productsTotal += product.GetTotalCost();
        }

        double shippingCost = _customer.IsUSA() ? 5.00 : 35.00;

        return productsTotal + shippingCost;
    }

    // Method to generate the packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Method to generate the shipping label
    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"Customer Name: {_customer.GetName()}\n";
        label += $"Address:\n{_customer.GetAddress().GetFullAddressString()}";
        return label;
    }
}