public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address()
    {

    }

    public bool IsLocationUSA (string country)
    {
        if (country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void SetStreetAddress()
    {
        Console.Write("Please enter street address: ");
        _streetAddress = Console.ReadLine();
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    private void SetCity()
    {
        Console.Write("Please enter city: ");
        _city = Console.ReadLine();
    }

    public string GetCity()
    {
        return _city;
    }

    private void SetStateOrProvince()
    {
        Console.Write("Please enter state or province: ");
        _stateOrProvince = Console.ReadLine();
    }

    public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }

    private void SetCountry()
    {
        Console.Write("Please enter country: ");
        _country = Console.ReadLine();
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetAddress()
    {
        SetStreetAddress();
        SetCity();
        SetStateOrProvince();
        SetCountry();
    }

    public string DisplayAddressInfo()
    {
        string addressInfo = $"Street: {GetStreetAddress()}\nCity: {GetCity()}\nState/Province: {GetStateOrProvince()}\nCountry: {GetCountry()}";
        return addressInfo;
    }

}
