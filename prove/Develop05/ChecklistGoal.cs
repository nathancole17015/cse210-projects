public class ChecklistGoal:Base{
private string _type  = "CheckList";
private string _name;
private string _description;
private int _points;
private int _bonusPoints;
private int _times;
private int _completed = 0;
public ChecklistGoal(string name, string description, int points, int times,int bonusPoints){
            _name = name;
            _description = description;
            _points = points;
            _bonusPoints = bonusPoints;

}
    public override void CreateNewGoal()
    {
        base.CreateNewGoal();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
    }
    public override string GetGoal(){
    return $"{_type},{_name} -- Currently completed: {_completed}/{_times}";
}
}