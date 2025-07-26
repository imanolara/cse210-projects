// Address.cs
using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor to initialize address details
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Method to check if the address is in the USA
    public bool IsUSA()
    {
        // Simple check for "USA" - could be more robust with multiple country codes/names
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    // Method to return a formatted string of the full address
    public string GetFullAddressString()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}