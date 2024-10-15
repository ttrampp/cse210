using System;
using System.Reflection.Metadata.Ecma335;

class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string cusName, Address address)
    {
        _customerName = cusName;
        _address = address;
    }

    /*public bool InUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }*/

    public bool InUSA()
    {
        return _address.InUSA();
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }

    /*public string DisplayCustomerInfo()
    {
        string customer = $"{_customerName}\n{address.GetAddress()}";
        return customer;
    }*/


}