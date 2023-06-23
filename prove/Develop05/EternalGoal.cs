public class EternalGoals:Base{
    private string _type = "EternalGoals";
    private string _name;
    private string _description;
    private int _points;
    
    public EternalGoals(string name, string description, int points ){
            _name = name;
            _description = description;
            _points = points;
    }

}