public class Product
{
    string _name;
    int _id;
    int _price;
    int _quantity;    

    public Product(string name, int id)
    {
        _name = name;
        _id = id;
    }
    public void SetPrice(int price)
    {
        _price = price;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetId()
    {
        return _id;
    }
    public int calculatePrice()
    {
        return _price * _quantity;
    }
}