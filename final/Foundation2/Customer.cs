public class Customer
{
    string _name;
    Address _address = new Address();

    public void SetCustomer(string name){
        _name = name;
    }
    public string GetName(){
        return _name;
    }
    public void SetAddress(string street, string city, string state, string country)
    {
        _address.SetAddress(street, city, state, country);
    }
    public string GetAddress(){
        return _address.Stringify();
    }
    public bool livingInTheUS()
    {
        return _address.nationalVSinternational();
    }
}