public class SimpleGoal:Goals{
    private string _type = "SimpleGoal"; 
    private string _name;
    private string _description;
    private int _points;
    private Boolean _completed;
public SimpleGoal(){
    _completed =false;
}
public override void IsComplete(Goals goal)
    {  
        Console.ReadLine();
        _completed = true;
        if (_completed){
          
        base.IsComplete(goal);
        Console.WriteLine("hi");
        goal.SetDone();
        }
    }
  
     public override string GetGoal()
    {
        return $"{_type},{base.GetGoal()},{_completed}";
    }


}