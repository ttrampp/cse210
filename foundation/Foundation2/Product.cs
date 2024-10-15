using System;
using System.Data.Common;

class Product
{
    private string _productName;
    private int _productId;
    private double _productPrice;
    private int _productQty;

    public Product(string proName, int proId, double proPrice, int proQty)
    {
        _productName = proName;
        _productId = proId;
        _productPrice = proPrice;
        _productQty = proQty;
    }

    public double GetTotalProductCost()
    {
        return _productPrice * _productQty;
    }

    public string GetPackingLabel()
    {
        return $"{_productName} (ID: {_productId})";
    }




}