public class ChecklistGoal:Goals{
private string _type;
private int _bonusPoints;
private int _times;
private int _completed ;

public ChecklistGoal(){
    _type = "ChecklistGoal";
    _completed = 0;
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
    public override string ShowGoal(){
       
    return $"{base.ShowGoal()} --- Currently completed: {_completed}/{_times}";
}

//     public override string ShowDone(){
       
//     return $"{base.ShowGoal()} --- Currently completed: {_completed}/{_times}";
// }
    public void SetTimes(int times){
        _times = times;
    }
     public void SetBonusPoints(int bonusPoints){
        _bonusPoints = bonusPoints;
    }
    public int GetBonusPoints(){
        return _bonusPoints;
    }
    public override void IsComplete(Goals goal)
    {
        Console.ReadLine();
        _completed =+ 1;
        if (_completed == _times){
            
            _totalPoints =+ GetBonusPoints();
        }
        base.IsComplete(goal);
    }
    public override string GetGoal()
    {
        return $"{_type},{base.GetGoal()},{_bonusPoints},{_times},{_completed}";
    }

    public override void RecordEvents(List<Goals> _goals,int input){
    
        
       for (int i = 0; i < _goals.Count; i++){
       
                var goal = _goals[i];
            if (i + 1 == input){
                _completed += 1;
                if (_completed == _times){
                IsComplete(goal);
               _goals.Remove(goal);
               goal.SetDone();
               _goals.Add(goal);

                }

        
         }
         

    }
   
    
}


   

}
