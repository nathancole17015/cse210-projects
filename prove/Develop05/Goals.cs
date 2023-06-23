public class Goals{
private string _type;
private string _name;
private string _description;
private int _points = 0;
private int _totalPoints = 0;
List <string> _goals = new List<string>();
public Goals(){

}
public virtual void CreateNewGoal(){
    Console.Write("What is the name of your goal? ");
    string _name = Console.ReadLine();
    setName(_name);
    Console.Write("What is a short description? ");
    string _description = Console.ReadLine();
    setDescription(_description);
    Console.Write("What is the amount of points associated with this goal? ");
    int _points = Int32.Parse(Console.ReadLine());
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
public int GetPoints(){
    return _points;

}
public string GetName(){
    return _name;
}
public void RecordEvents(){
    Console.WriteLine(" Your goals: ");
    for (int i = 0; i < _goals.Count; i++)
{
        var goal = _goals[i];
        Console.WriteLine($"{i + 1}. {GetName()}");
    }
    Console.WriteLine("choose goal to record");
    string input = Console.ReadLine();
    if (input == _goals[0]){
        IsComplete();

    }
  
    
}
public virtual string GetGoal(){
    return $"{_type}:{_name},{_description},{_points}";

}
public virtual string ShowGoal(){

    return $"[] {_name} ({_description})";
}
public virtual void IsComplete(){
  int EarnedPoints = GetPoints();
    _totalPoints += EarnedPoints;

}
}





