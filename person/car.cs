// See https://aka.ms/new-console-template for more information
public class Car{
    //instances 
    public string brand;
    public int miles;
    public string color;

    // constructor 
    public Car(){}


    //methods(functions)
    public void move_forward(){

        Console.WriteLine("is running");
    }

    public void display_info(){
        Console.WriteLine($"Brand: {brand} Miles: {miles} Color: {color}");
    }
}