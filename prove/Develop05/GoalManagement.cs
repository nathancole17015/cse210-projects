using System.IO; 
public class GoalManagement{
 
 
public void SaveGoals(Goals goal){




string filename = Console.ReadLine();

using (StreamWriter outputFile = new StreamWriter(filename))
{
    // You can add text to the file with the WriteLine method
    string hi = goal.GetGoal();
    outputFile.WriteLine(hi);
    
    // You can use the $ and include variables just like with Console.WriteLine
    string color = "Blue";
    outputFile.WriteLine($"My favorite color is {color}");
}
}
public void  LoadGoals(){
Console.Write("Enter file name");
string filename = Console.ReadLine();
string[] lines = System.IO.File.ReadAllLines(filename);

foreach (string line in lines)
{
    string[] parts = line.Split(",");

    string name = parts[1];
    string description = parts[2];
    int points = Int32.Parse(parts[3]);
}
} 

}