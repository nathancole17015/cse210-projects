public class BreathingActivity : BaseActivity{



public BreathingActivity(){
    _name = "Breathing Activity";
    _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
    _duration = 0;
}

public void BreathingExercise(){
    Console.WriteLine();
    Console.Write("Breathe in...");
    PauseCountdown(4);
    Console.WriteLine();
    Console.Write("Now Breathe out...");
    PauseCountdown(6);
    Console.WriteLine();
   
}
public void RunExercise(){
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    while(DateTime.Now < endTime){
        BreathingExercise();
    }
}
public void Display(){
    DisplayStartMessage();
    RunExercise();
    DisplayEndMessage();


    
}
}