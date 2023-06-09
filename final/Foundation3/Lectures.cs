public class Lectures:Events{
// Lectures, which have a speaker and have a limited capacity.
   
    private int _capacity;
    private string _speakerName;
    
    private Address _address;
    public Lectures(string type,string title, string description, string date, string time,string  speakerName, int capacity ,Address address)  : base(type, title, description, date, time, address){
           
            _speakerName = speakerName;
            _capacity = capacity;
    }
    public void Display(){
        Console.WriteLine();
        Console.WriteLine("======================================");
        Console.WriteLine();
        Console.WriteLine("Standard Details");
        StandardInformation();
        Console.WriteLine();
        Console.WriteLine("Full Details");
        StandardInformation();
        Console.WriteLine($"Speaker: {_speakerName}");
        Console.WriteLine($"Capacity: {_capacity}");
        Console.WriteLine();
        Console.WriteLine("Short Description");
        ShortDescription();
        Console.WriteLine();
        Console.WriteLine("======================================");
                
        
    }
}