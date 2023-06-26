using System.IO; 
public class GoalManagement{

 
public void SaveGoals(string filename, List<Goals> _goals){




    using (StreamWriter outputFile = new StreamWriter(filename))
    {
    // You can add text to the file with the WriteLin(e method
    
            foreach (Goals goal in _goals){
            outputFile.WriteLine($"{goal.GetGoal()}");  
        }

        }
}

public void LoadGoals(string filename, List<Goals> _goals){
          if (filename == ""){
            foreach (Goals goal in _goals){
            Console.WriteLine($"{goal.GetGoal()}\n");
        }
          }
        else{
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines){   
        

          string[] parts = line.Split(',');
            if(parts[0] == "SimpleGoal"){
                SimpleGoal simpleGoal = new SimpleGoal();
                simpleGoal.SetNotDone();
                simpleGoal.SetName(parts[1]);
                simpleGoal.SetDescription(parts[2]);
                simpleGoal.SetPoints(int.Parse(parts[3]));
                _goals.Add(simpleGoal);

            }
             if(parts[0] == "EternalGoal"){
                EternalGoals eternalGoal = new EternalGoals();
                eternalGoal.SetNotDone();
                  eternalGoal.SetName(parts[1]);
                eternalGoal.SetDescription(parts[2]);
                eternalGoal.SetPoints(int.Parse(parts[3]));
                _goals.Add(eternalGoal);
            }
             if(parts[0] == "ChecklistGoal"){
                ChecklistGoal checkListGoal = new ChecklistGoal();
                checkListGoal.SetNotDone();
                checkListGoal.SetName(parts[1]);
                checkListGoal.SetDescription(parts[2]);
                checkListGoal.SetPoints(int.Parse(parts[3]));
                checkListGoal.SetBonusPoints(int.Parse(parts[6]));
                checkListGoal.SetTimes(int.Parse(parts[5]));
                _goals.Add(checkListGoal);


            }
            
            
            }
        }
    }

}