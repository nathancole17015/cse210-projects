public class Swimming: Activity{

    private int _swimming_laps;
   
    
    private double _minutes;
public Swimming(string date, string type, double minutes, int swimming_laps): base(date, type, minutes){
    _swimming_laps = swimming_laps;
    _minutes = minutes;
}
    public override double GetDistance()
    {   double _distance = _swimming_laps * 50 / 1000 * 0.62;
        
        return Math.Round(_distance,2);
    }
    public override double GetSpeed()
    {   double _distance = GetDistance();
        double _speed = (_distance / _minutes) * 60;
        return Math.Round(_speed, 2);
    }
    public override double GetPace()
    {   
        double _distance = GetDistance();
        double _pace = _minutes / _distance;
        return Math.Round(_pace,2);
    }

}