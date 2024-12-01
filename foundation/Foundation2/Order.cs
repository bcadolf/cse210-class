using System.Drawing;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    private double AddSubtotal()
    {
        double price = 0;
        foreach (Product item in _products)
        {
            (string product, double total) = item.GetProduct();
            price += total;
        }
        return price;
    }

    private int CalculateShipping()
    {
        int cost;
        (string na, bool location) = _customer.GetCustomer(); // string marked as na since it is not used
        if (location == true)
        {
            cost = 5;
        }
        cost = 35;
        return cost;
    }

    public void AddProduct(Product newItem)
    {
        _products.Add(newItem);
    }

    public string GetPackingLabel()
    {
        string orderItems = String.Join("\n", _products.Select(item => item.GetProduct().Item1));

        return $"Packing Slip\n~~~~~~~~~~~~~~~~~~~~~~~\nID | Name\n{orderItems}\n~~~~~~~~~~~~~~~~~~~~~~~\nSubtotal: {AddSubtotal()} \nShipping: {CalculateShipping()} \nTotal: {AddSubtotal() + CalculateShipping()}\n";
    }

    public string GetShippingLabel()
    {
        (string demo, bool na) = _customer.GetCustomer(); // bool marked as na since it is not used

        return demo;
    }
}