public class ReflectionActivity : BaseActivity{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

public ReflectionActivity(){
    _name = "Reflecting Activity";
    _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
    _duration = 0;

    _prompts.Add("Think of a time when you stood up for someone else.");
    _prompts.Add("Think of a time when you did something really difficult.");
    _prompts.Add("Think of a time when you helped someone in need.");
    _prompts.Add("Think of a time when you did something truly selfless.");

    _questions.Add("Why was this experience meaningful to you?");
    _questions.Add("Have you ever done anything like this before?");
    _questions.Add("How did you get started?");
    _questions.Add("How did you feel when it was complete?");
    _questions.Add("What made this time different than other times when you were not as successful?");
    _questions.Add("What is your favorite thing about this experience?");
    _questions.Add("What could you learn from this experience that applies to other situations?");
    _questions.Add("What did you learn about yourself through this experience?");
    _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void DisplayRandomPrompt(){
        var random = new Random();
        int randomNumber = random.Next(0,_prompts.Count);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine( $"--- {_prompts[randomNumber]} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may being in: ");
        PauseCountdown(8);




    }
     public void DisplayRandomQuestion(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

       
        while(DateTime.Now < endTime){
        var random = new Random();
        int randomNumber = random.Next(0,_questions.Count);
        Console.Write( $"> {_questions[randomNumber]} ");
        PauseSpinner();
        Console.WriteLine();
        }
    }   
    public void Display(){
        DisplayStartMessage();
        DisplayRandomPrompt();
        Console.Clear();
        DisplayRandomQuestion();
        DisplayEndMessage();
       
    }
    }
