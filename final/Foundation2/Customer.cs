public class Customers{
    private Address _address;
    private string _name;
    public Customers(string name, Address address){
        _name = name;
        _address = address;
    }

    public string GetCustomerName(){
        return _name;
    }
    public string GetAddress(){

        return _address.StringifyAddress();
    }
    public bool InUSACustomer(){

       return _address.InUSA();;
    }
}