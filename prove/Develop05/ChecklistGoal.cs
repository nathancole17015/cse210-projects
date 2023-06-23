public class ChecklistGoal:Goals{
private string _type  = "CheckList";
private string _name;
private int _bonusPoints;
private int _times;
private int _completed ;
private string _description;
public ChecklistGoal(){

}


    public override void CreateNewGoal()
    {
        base.CreateNewGoal();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int _times = Int32.Parse(Console.ReadLine());
        SetTimes(_times);
        Console.Write("What is the bonus for accomplishing it that many times? ");
         int _bonusPoints = Int32.Parse(Console.ReadLine());
         SetBonusPoints(_bonusPoints);
    }
    public override string GetGoal(){
    return $"[ ] {_name} ({_description}) -- Currently completed: {_completed}/{_times}";
}
    public void SetTimes(int times){
        _times = times;
    }
     public void SetBonusPoints(int bonusPoints){
        _bonusPoints = bonusPoints;
    }
   

}
