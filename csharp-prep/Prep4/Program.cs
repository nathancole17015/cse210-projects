using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int numberInput = -1;
        
        while(numberInput != 0 ){

        Console.Write("Input a number: ");
        numberInput = int.Parse(Console.ReadLine());
        numbers.Add(numberInput);

        }
        int sum = 0;
        foreach (int num in numbers){
            sum += sum=num;
        }

        Console.WriteLine($"The sum is {sum}");

        float average = 0;
        foreach(int num in numbers){
            average = ((float)sum) / numbers.Count;
        }
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];
        foreach(int num in numbers){
            if(max > num){
               max = num; 
            }
    
        }

        Console.WriteLine($"The max is {max}");
    }
}       