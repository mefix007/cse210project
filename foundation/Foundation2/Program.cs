using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // Product
        Product product1 = new Product("Laptop", "P101", 1000, 1);
        Product product2 = new Product("Mouse", "P102", 25, 2);
        Product product3 = new Product("Keyboard", "P103", 50, 1);
        Product product4 = new Product("Iphone", "P201", 800, 1);
        Product product5 = new Product("Laptop", "P202", 30, 2);

        // Customer Address
        CustomerAddress address1 = new CustomerAddress("B23 Elm st", "New York", "NY", "USA");
        CustomerAddress address2 = new CustomerAddress("126NT vineview st", "Nirhadram", "Toroto", "CANADA");

        // Customer details
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Chris Smith", address2);

        // order details
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Details of each order
        Console.WriteLine("Order 1: ");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
        Console.WriteLine(new string('-', 40));

        Console.WriteLine("Order 2: ");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
        Console.WriteLine(new string('-', 40));

    }


}
public class Product
{
    private string _productName;
    private string _productID;
    private double _productPrice;
    private int _productQuantity;

    public Product(string productName, string productID, double productPrice, int productQuantity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }
    public string GetProductName()
    {
        return _productName;
    }
    // public void SetProductName(string productName)
    // {
    //     _productName = productName;
    // }
    public string GetProductID()
    {
        return _productID;
    }
    // public void SetProductID(string productID)
    // {
    //     _productID = productID;
    // }
    public double GetProductPrice()
    {
        return _productPrice;
    }
    public int GetProductQuantity()
    {
        return _productQuantity;
    }
    public double GetTotalCost()
    {
        return _productPrice * _productQuantity;
    }
}
public class Customer
{
    private string _customerName;
    public CustomerAddress _customerAddress;

    public Customer(string customerName, CustomerAddress customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }
    public string GetCustomerName()
    {
        return _customerName;
    }
    // public void SetCustomerName(string customerName)
    // {
    //     _customerName = customerName;
    // }
    public CustomerAddress GetCustomerAddress()
    {
        return _customerAddress;
    }
    public bool IsInUSA()
    {
        return _customerAddress.IsInUSA();
    }
}
public class CustomerAddress
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public CustomerAddress(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }
    public string Street()
    {
        return _street;
    }
    public string City()
    {
        return _city;
    }
    public string StateOrProvince()
    {
        return _stateOrProvince;
    }
    public string Country()
    {
        return _country;
    }
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }
    public string FullAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in _products)
        {
            packingLabel += $"{product.GetProductName()} ID: {product.GetProductID()}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer._customerAddress.FullAddress()}";
    }
    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        total += _customer.IsInUSA() ? 5 : 35;
        return total;
    }
}