public class Menu
{
GoalManagement _manageGoal = new GoalManagement();
List <Goals> _goals = new List<Goals>();
Goals _goal = new Goals();
private int _totalPoints = 0;

    

    public void Display(){
      
        Console.Clear();
        string response = "";
        string[] options = {"1","2","3","4","5"};
        while(response != "6")
        {
           
            response = "";
            while(options.Contains(response)==false)
            {
                
                Console.WriteLine();
                Console.WriteLine($"You have {_goal.ShowTotalPoints()} points.");
                Console.WriteLine();
                Console.WriteLine("Menu Options:");
                Console.Write("\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals \n    4.Load Goals\n    5.Record Event\n    6.Quit\n\n  Select choice from menu: ");
                response = Console.ReadLine() ?? String.Empty;
            
            switch(response){
                case "6":
                    Environment.Exit(0);
                    break;
                case "1": 
                    Console.WriteLine("The type of goals are: ");
                    Console.WriteLine(" 1. Simple Goal");
                    Console.WriteLine(" 2. Eternal Goal ");
                    Console.WriteLine(" 3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create?  ");
                    string input = Console.ReadLine();
                    if (input == "1"){
                         SimpleGoal _simpleGoal = new SimpleGoal();
                        _simpleGoal.CreateNewGoal();
                      
                        _goals.Add(_simpleGoal);


                    }
                    else if(input == "2"){
                        EternalGoals _eternalGoal = new EternalGoals();
                        _eternalGoal.CreateNewGoal();
                      
                        _goals.Add(_eternalGoal);

                    }
                    else if (input == "3"){
                        ChecklistGoal _checklistGoal = new ChecklistGoal();
                        _checklistGoal.CreateNewGoal();
                        
                        
                        _goals.Add(_checklistGoal);

                        
                    }
                    else 
                    break;

                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Your Goals: ");
                 
                    for (int i = 0; i < _goals.Count; i++)
                    {
                        var goal = _goals[i];
                    Console.WriteLine($"    {i + 1}. {goal.ShowGoal()}");
                            }
                break;
                case "3":
                    Console.Write("What do you want to name your file (don't add .txt) ");
                    string filename = Console.ReadLine();
                    _manageGoal.SaveGoals(filename + ".txt", _goals);
                        
                   
                    
                    
                break;
             case "4":
                    Console.Write("What file do you want to load (don't add .txt) ");
                    string loadFile = Console.ReadLine();
                    _manageGoal.LoadGoals(loadFile + ".txt", _goals);
                   
                    
                    
                break;
                 case "5":
                    
                    _goal.RecordEvents(_goals);
                 
                    
                    
                break;
              
            }
            response = "";

        }
    }
    }

}

