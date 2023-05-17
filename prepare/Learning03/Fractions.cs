public class Fractions{

    private int _top;
    private int _bottom;

    public Fractions(){
        Console.WriteLine(1/1);

    }
    public Fractions(int wholeNumber){
        Console.WriteLine(wholeNumber/1);

    }
    public  Fractions(int top, int bottom){
        _top = top;
        _bottom = bottom;

    }
    public void GetTop(){

        Console.Write("What is your top number");
       string  top = Console.ReadLine();
        int topNum = int.Parse(top);

    }
            
    public void SetTop(){}

    public void GetBottom(){
        Console.Write("What is your bottom number");
       string  bottom = Console.ReadLine();
        int bottomNum = int.Parse(bottom);
    }

    public void SetBottom(){
    }
}