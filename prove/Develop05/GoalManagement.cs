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
                simpleGoal.setName(parts[1]);
                simpleGoal.setDescription(parts[2]);
                simpleGoal.setPoints(int.Parse(parts[3]));
                _goals.Add(simpleGoal);

            }
             if(parts[0] == "EternalGoal"){
                EternalGoals eternalGoal = new EternalGoals();
                eternalGoal.SetNotDone();
                  eternalGoal.setName(parts[1]);
                eternalGoal.setDescription(parts[2]);
                eternalGoal.setPoints(int.Parse(parts[3]));
                _goals.Add(eternalGoal);
            }
             if(parts[0] == "ChecklistGoal"){
                ChecklistGoal checkListGoal = new ChecklistGoal();
                checkListGoal.SetNotDone();
                checkListGoal.setName(parts[1]);
                checkListGoal.setDescription(parts[2]);
                checkListGoal.setPoints(int.Parse(parts[3]));
                checkListGoal.SetBonusPoints(int.Parse(parts[6]));
                checkListGoal.SetTimes(int.Parse(parts[5]));
                _goals.Add(checkListGoal);


            }
            
            
            }
        }
    }

}