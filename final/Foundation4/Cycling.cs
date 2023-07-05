public class Cycling:Activity{
    private double _speed;
    private double _minutes;

    public Cycling(string date, string type, double minutes, double speed): base(date, type, minutes){
    _speed = speed;
    _minutes = minutes;

}

   
    public override double GetDistance()
    {   double _distance = (_minutes/60) * _speed;
        return _distance;
    }
    public override double GetPace()
    {   double _pace = 60 / _speed;
        return _pace;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
}