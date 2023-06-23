public class Menu{

private string _name;
private string _description;
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
                Console.Clear();
                Console.WriteLine($"You have {_totalPoints} points.");
                Console.WriteLine();
                Console.WriteLine("Menu Options:");
                Console.Write("\n   1. Create New Goal\n    2. List Goals\n 3. Save Goals \n    4.Quit\n\n  Select choice from menu: ");
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
                        
                    }
                    else if(input == "2"){

                    }
                    else if (input == "3"){

                    }
                    else 
                    break;

                    break;
                case "2":
                    

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

