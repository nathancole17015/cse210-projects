public class Events{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;

    public Events(string type, string title, string description, string date, string time, Address address ){
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

    }
    
    public void StandardInformation(){
  
    Console.WriteLine($"Type: {_type}");
    Console.WriteLine($"Title: {_title}" );
    Console.WriteLine($"Description: {_description}");
    Console.WriteLine($"Date: {_date}");
    Console.WriteLine($"Time: {_time}");
    Console.WriteLine($"Address: {_address.GetAddress()}");
    }
}

