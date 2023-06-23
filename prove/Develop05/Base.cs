public class Base{
private string _name;
private string _description;
private int _points;
public virtual void CreateNewGoal(){
    Console.Write("What is the name of your goal? ");
    string _name = Console.ReadLine();
    Console.Write("What is a short description? ");
    string _description = Console.ReadLine();
    Console.Write("What is the amount of points associated with this goal? ");
    int _points = Int32.Parse(Console.ReadLine());

}
public void ListGoals(){

}
public void SaveGoals(){

}
public void  LoadGoals(){

} 
public void RecordEvents(){

}
public virtual string GetGoal(){

    return $"{_type},{_name},{_description},{_points}";
}
};



