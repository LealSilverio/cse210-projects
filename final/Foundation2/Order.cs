public class Order
{
    string label;
    string address;
    int _shipping;
    int _total;
    List<Product> _products = new List<Product>();
    Customer c = new Customer();

    public void SetList(List<Product> products)
    {
        _products = products;
    }
    public List<Product> GetList()
    {
        return _products;
    }
    public int calculateTotal()
    {
        int prices = _products.Count();
        if (address == "USA")
        {
            _shipping = 5;
        }
        else{
            _shipping = 35;
        }
        _total = prices + _shipping;
        return _total;
    }
    public string packingLabel(string name, int id)
    {
        foreach (Product p in _products)
        {
            label = $"{name} - {id}";
        }
        return label;
    }
    public string shippingLabel(string name, string address)
    {
        return $"{name} - {address}";
    }
}