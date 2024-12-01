public class Customer
{
    private string _first;
    private string _last;
    private string _middle;
    private Address _address;

    public Customer(string firstName, string lastName, Address address)
    {
        _first = firstName;
        _last = lastName;
        _address = address;
    }
    public Customer(string firstName, string lastName, string middleName, Address address)
    {
        _first = firstName;
        _last = lastName;
        _middle = middleName;
        _address = address;
    }

    private bool CheckLocation()
    {
        return _address.Location();
    }
    public (string, bool) GetCustomer()
    {
        string name;
        if (_middle != null)
        {
            name = $"{_first} {_middle} {_last}";
        }
        else
        {
            name = $"{_first} {_last}";
        }
        string demo = $"{name},{_address.GetAddress()}";

        return (demo, CheckLocation());
    }
}