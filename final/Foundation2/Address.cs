public class Address{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _inUSA = false;
    public Address(string street, string city, string state,string country){
        _street = street;
        _city = city;
        _state =state;
        _country = country;

    }

    public bool InUSA(){
        if (_country == "USA"){
            _inUSA = true;
        }
        else {
            _inUSA = false;
        }
        return _inUSA;
    }
    public string StringifyAddress(){
        return $"{_street}, {_city}, {_state} {_country}";
    }

}