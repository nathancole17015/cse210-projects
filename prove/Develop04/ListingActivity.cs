public class ListingActivity : BaseActivity{

private List<string> _prompts = new List<string>();
private List<string> _inputs = new List<string>();


public ListingActivity(){
    _name = "Listing Activity";
    _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
    _duration = 0;

    
    _prompts.Add("Who are people you appreciate");
    _prompts.Add("What are personal strengths of yours");
    _prompts.Add("Who are people that you have helped this week ");
    _prompts.Add("When have you felt the Holy Ghost this month");
    _prompts.Add("Who are some of your personal heroes");
   
   
}
 public void DisplayRandomPrompt(){
        var random = new Random();
        int randomNumber = random.Next(0,_prompts.Count);
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine( $"--- {_prompts[randomNumber]} ---");
        Console.Write("You may begin in: ");
        PauseCountdown(5);
        
    }
public void Listing(){
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);
    Console.WriteLine("");
    while(DateTime.Now < endTime){
        Console.Write("> ");
        string input =Console.ReadLine();
        _inputs.Add(input);
    }
        int count =_inputs.Count;
        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");
        _inputs.Clear();
    }
public void Display(){
    DisplayStartMessage();
    DisplayRandomPrompt();
    Listing();
    DisplayEndMessage();

}
}