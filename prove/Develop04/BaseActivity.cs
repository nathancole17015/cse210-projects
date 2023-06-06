public class BaseActivity{
public int _duration;
public string _name;
public string _description;

public void DisplayStartMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseSpinner();
}

public void DisplayEndMessage(){
    Console.WriteLine();
    Console.WriteLine("Well Done!!");
    Console.WriteLine();
    Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
    PauseSpinner();
}
public void PauseSpinner(){
List <string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");


        foreach (string s in animationString){
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            }
}
public void PauseCountdown(int length){
    
    for(int i = length; i > 0; i--){
         Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");

    }
    

}

}


