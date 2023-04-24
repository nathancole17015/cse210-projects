using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        int grade = int.Parse(gradePercent);
        
        if (grade >= 90){
            Console.WriteLine("Your grade is a A");
        }
        else if (grade >= 80 && grade < 90){
            Console.WriteLine("Your grade is a B");
        }
        else if (grade >= 70 && grade < 80){
            Console.WriteLine("Your grade is a C");
        }
        else if (grade >= 60 && grade < 70){
            Console.WriteLine("Your grade is a D");
        }
        else {
            Console.WriteLine("Your grade is a F");
        }

        if(grade >= 70 ){
            Console.WriteLine("You passed! Congratulations!");
        }
        else{
            Console.WriteLine("You Failed");

        }
    }
}