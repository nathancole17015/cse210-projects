public class Goals{
private string _type;
private string _name;
private string _description;
private int _points = 0;
public int _totalPoints = 0;
private string _done;
public Goals(){

}
public virtual void CreateNewGoal(){
    SetNotDone();
    Console.Write("What is the name of your goal? ");
    string _name = Console.ReadLine();
    setName(_name);
    Console.Write("What is a short description? ");
    string _description = Console.ReadLine();
    setDescription(_description);
    Console.Write("What is the amount of points associated with this goal? ");
    int _points = int.Parse(Console.ReadLine());
    setPoints(_points);

}
public void setName(string name){
    _name = name ;
}
public void setDescription(string description){
    _description = description;
}
public void setPoints(int points){
    _points = points;
}
public string ShowType(){
    return _type;
}
public void setTotalPoints(int totalPoints){
    _totalPoints = totalPoints;
}
public int ShowTotalPoints(){
        return _totalPoints;
}
public int GetPoints(){
    return _points;

}
public string GetName(){
    return _name;
}
public virtual void RecordEvents(List<Goals> _goals){
    Console.WriteLine(" Your goals: ");
    for (int i = 0; i < _goals.Count; i++)
{
        var goal = _goals[i];
        Console.WriteLine($"    {i + 1}. {goal.GetName()}");

         
     
        }
         Console.Write("Choose goal to record: ");
        int input = int.Parse(Console.ReadLine());
       for (int i = 0; i < _goals.Count; i++){
       
                var goal = _goals[i];
            if (i + 1 == input){
                IsComplete(goal);
               _goals.Remove(goal);
               goal.SetDone();
               _goals.Add(goal);

            

        
         }
         

    }
   
    
}
public virtual string GetGoal(){
    return $"{_name},{_description},{_points}";

}
public void SetNotDone(){
    _done = "[ ]";
}
public void SetDone(){
    _done = "[X]";
}
public virtual string ShowGoal(){

    return $"{_done} {_name} ({_description})";
}
public virtual  string ShowDone(){
    return $"[x] {_name} ({_description})";

}
public virtual void IsComplete(Goals goal){
    
  int EarnedPoints = goal.GetPoints();
    _totalPoints += EarnedPoints;
    setTotalPoints(_totalPoints);
    
    goal.SetDone();
    

}
}

