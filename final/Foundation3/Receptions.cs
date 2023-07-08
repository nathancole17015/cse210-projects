public class Receptions:Events{
//Receptions, which require people to RSVP, or register, beforehand.
     
    
 
    private string _email;
    public Receptions(string type,string title, string description, string date, string time, string email,Address address)  : base(type, title, description, date, time, address){
         
            _email =email;
    }

    public void Display(){
        Console.WriteLine();
        Console.WriteLine("======================================");
        Console.WriteLine();
        Console.WriteLine("Standard Details");
        StandardInformation();
        Console.WriteLine("Full Details");
        StandardInformation();
        Console.WriteLine($"RSVP Email: {_email}");
        Console.WriteLine();
        Console.WriteLine("Short Description");
        ShortDescription();
        Console.WriteLine();
        Console.WriteLine("======================================");
                
        
    }
}