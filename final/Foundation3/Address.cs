public class Address
{
    string _street;
    string _city;    
    string _state;
    string _country;
    bool _national;

    public void SetAddress(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public string Stringify()
    {
        return $"{_street}\n{_city}, {_state} {_country}";
    }
}