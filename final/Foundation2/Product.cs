public class Products{
    private string _name;
    private int _productID;
    private double  _price;
    private int _quantity;
    private double _totalPrice = 0;
    public Products(string name, int productID, double price, int quantity){
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;

    }

    public double GetTotalPrice(){
        _totalPrice = _price * _quantity;
        return _totalPrice;
    }
    public int GetProductID(){
        return _productID;
    }
    public string GetProductName(){
        return _name;
    }
}   