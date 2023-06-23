public class SimpleGoal:Base{
    private string _type = "SimpleGoal"; 
    private string _name;
    private string _description;
    private int _points;
    private Boolean _completed = false;
public SimpleGoal(string name, string description, int points){

}

public override string GetGoal(){
    return $"{_type},{_name},{_description},{_points}";
}
}