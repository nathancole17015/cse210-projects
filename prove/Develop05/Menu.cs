
public class Menu{
List <string> _goals = new List<string>();

List <Goals> _goal = new List<Goals>();
Goals _aGoal = new Goals();
private string _name;
private string _description;
private int _totalPoints = 0;
    

    public void Display(){
        _goals.Clear();
        Console.Clear();
        string response = "";
        string[] options = {"1","2","3","4","5"};
        while(response != "6")
        {
           
            response = "";
            while(options.Contains(response)==false)
            {
                
                Console.WriteLine($"You have {_totalPoints} points.");
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
                    Console.WriteLine();
                    Console.WriteLine(" 2. Eternal Goal ");
                    Console.WriteLine(" 3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create?  ");
                    string input = Console.ReadLine();
                    if (input == "1"){
                         SimpleGoal _simpleGoal = new SimpleGoal();
                        _simpleGoal.CreateNewGoal();
                        string Simple =_simpleGoal.ShowGoal();
                        _goals.Add(Simple);

                    }
                    else if(input == "2"){
                        EternalGoals _eternalGoal = new EternalGoals();
                        _eternalGoal.CreateNewGoal();
                        string eternal = _eternalGoal.ShowGoal();
                        _goals.Add(eternal);
                        

                    }
                    else if (input == "3"){
                        ChecklistGoal _checklistGoal = new ChecklistGoal();
                        _checklistGoal.CreateNewGoal();
                        string check = _checklistGoal.ShowGoal();
                        _goals.Add(check);
                        
                        
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
                    Console.WriteLine($"{i + 1}. {goal}");
                            }
                break;
                case "3":
                    

                   
                    
                    
                break;
             case "4":
                    
                    
                   
                    
                    
                break;
                 case "5":
                    
                    
                 
                    
                    
                break;
              
            }
            response = "";

        }
    }
    }

}

