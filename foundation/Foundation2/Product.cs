using System.ComponentModel.DataAnnotations;

public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int prodId, double price)
    {
        _name = name;
        _productId = prodId;
        _price = price;
        _quantity = 1;
    }
    public Product(string name, int prodId, double price, int quant)
    {
        _name = name;
        _productId = prodId;
        _price = price;
        _quantity = quant;
    }

    private double ComputeTotal()
    {
        return _price * _quantity;
    }

    public (string, double) GetProduct()
    {
        return ($"{_productId} {_name}", ComputeTotal());
    }
}