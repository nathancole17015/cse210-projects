public class Running: Activity{
    private double _distance;
    private double _minutes;


    public Running(string date, string type, double minutes, double distance): base(date, type, minutes){
    _distance = distance;
    _minutes = minutes;

}
    
    public override double GetSpeed()
    {   double _speed = (_distance / _minutes) *60;
        return _speed;
    }
    public override double GetPace()
    {  double _pace = _minutes / _distance;
        return _pace;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    
}