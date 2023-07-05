public class Order
{
    string label;
    int _shipping;
    int _total;
    List<Product> _products = new List<Product>();

    public void SetList(List<Product> products)
    {
        _products = products;
    }
    public List<Product> GetList()
    {
        return _products;
    }
    public int calculateTotal(bool nationalShipping, List<int> list)
    {
        int price = list.Sum();
        if (nationalShipping == true)
        {
            _shipping = 5;
        }
        else{
            _shipping = 35;
        }
        _total = price + _shipping;
        return _total;
    }
    public void packingLabel()
    {
        foreach (Product p in _products)
        {
            Console.WriteLine($"Name: {p.GetName()}\nID: {p.GetId()}");
            Console.WriteLine(string.Empty);
        }
        
    }
    public string shippingLabel(Customer c)
    {
        return $"{c.GetName()}\n{c.GetAddress()}";
    }
}