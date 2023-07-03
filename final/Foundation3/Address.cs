public class Address{
private string _street;
private string _city;

private string _state;
private string _country;

private int _zipCode;

public Address(string street, string city, string state, string country, int zipCode){
    _state = state;
    _street =street;
    _city = city;
    _country = country;
    _zipCode = zipCode;
}

public string GetAddress(){
    return $"{_street} {_city} {_state} {_country} {_zipCode}";
}
}