public  abstract class Activity{
private double _distance;
private double _speed;

private double _pace;
private double _minutes;
private string  _type; 
private string _date;
public Activity (string date , string type, double minutes){
    _date =date;
    _type = type;
    _minutes = minutes;
}


public void  GetSummary(){
    
    Console.WriteLine( $"{_date} {_type} ({_minutes}) - Distance {GetDistance().ToString("0.0")} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");


}
public abstract double GetDistance();

public abstract double GetSpeed();
public abstract double GetPace();




}
