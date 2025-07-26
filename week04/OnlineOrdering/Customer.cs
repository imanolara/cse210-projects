// Customer.cs
using System;

public class Customer
{
    private string _name;
    private Address _address; // Customer "has-a" an Address object

    // Constructor to initialize customer details
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to return the customer's name
    public string GetName()
    {
        return _name;
    }

    // Method to return the customer's Address object
    public Address GetAddress()
    {
        return _address;
    }

    // Method to check if the customer lives in the USA (delegates to Address)
    public bool IsUSA()
    {
        return _address.IsUSA();
    }
}