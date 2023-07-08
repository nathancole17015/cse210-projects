public class OutdoorGatherings:Events{
//Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.
  
    private string _weather;
    

    public OutdoorGatherings(string type, string title, string description, string date, string time,string weather, Address address)   : base(type, title, description, date, time, address){
          
            _weather = weather;
    }
    public void Display(){
        Console.WriteLine();
        Console.WriteLine("======================================");
        Console.WriteLine();
        Console.WriteLine("Standard Details");
        StandardInformation();
        Console.WriteLine("Full Details");
        StandardInformation();
        Console.WriteLine($"Weather: {_weather}");
        Console.WriteLine();
        Console.WriteLine("Short Description");
        ShortDescription();
        Console.WriteLine();
        Console.WriteLine("======================================");
       
    }
}