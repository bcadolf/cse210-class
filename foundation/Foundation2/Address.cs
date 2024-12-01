using System.ComponentModel.Design;
using System.Dynamic;

public class Address
{
    private string _street;
    private string _city;
    private string _administrativeDivision;
    private string _country;
    private int _postalCode;
    private bool _locationUSA;

    public Address(string street, string city, string adminDiv, string country, int postCode)
    {
        _street = street;
        _city = city;
        _administrativeDivision = adminDiv;
        _country = country;
        _postalCode = postCode;
    }

    private void CheckCountry()
    {
        if (_country != "USA")
        {
            _locationUSA = false;
        }
        _locationUSA = true;
    }

    public bool Location()
    {
        CheckCountry();
        return _locationUSA;
    }

    public string GetAddress()
    {
        return $"{_street},{_city},{_administrativeDivision},{_postalCode},{_country}";
    }
}