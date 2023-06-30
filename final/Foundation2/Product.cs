public class Product
{
    string _name;
    int _id;
    int _price;
    int _quantity;    

    public int calculatePrice()
    {
        return _price * _quantity;
    }
}