public class Customer
{
    string _name;
    Address _address = new Address();

    public void SetCustomer(string name, Address address){
        _name = name;
        _address = address;
    }
    public string GetName(){
        return _name;
    }
    public Address GetAddress(){
        return _address;
    }
    public void livingInTheUS()
    {
        _address.nationalVSinternational();
    }
}