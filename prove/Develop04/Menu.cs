public class Menu{

    
   private BreathingActivity _breathingActivity = new BreathingActivity();
   private ReflectionActivity _reflectionActivity = new ReflectionActivity();
   private ListingActivity _listingActivity = new ListingActivity();


    public void Display(){

        Console.Clear();
        string response = "";
        string[] options = {"1","2","3"};
        while(response != "4")
        {
           
            response = "";
            while(options.Contains(response)==false)
            {
                Console.Clear();
                Console.Write("\n1.Start breathing activity\n2.Start reflecting activity\n3.Start listing activity\n4.Quit\n\nSelect choice from menu: ");
                response = Console.ReadLine() ?? String.Empty;
            
            switch(response){
                case "4":
                    Environment.Exit(0);
                    break;
                case "1": 
                    _breathingActivity.Display();                  
                 
                    break;
                case "2":
                    _reflectionActivity.Display();

                break;
                case "3":
                    _listingActivity.Display();
                   
                    
                    
                break;
              
            }
            response = "";

        }
    }
    }

}

