using System;
using System.Numerics;

class Order
{
    private List<Product> products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalOrderCost()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalProductCost();
        }
        total += _customer.InUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += product.GetPackingLabel() + "\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomerName()}\n{_customer.GetAddress()}";
    }
}