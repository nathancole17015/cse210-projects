public class Menu{

    private Prompt _prompt = new Prompt();
    private  Journal _journal;

    public Menu(Journal journal){
        _journal = journal;
    }


    public void Display(){

        string response = "";
        string[] options = {"1","2","3","4"};
        while(response != "5")
        {

            while(options.Contains(response)==false)
            {
                Console.Write("1. Write:\n2.Display\n3.Load\n4.Save\n5.Quit\n\nWhat do you want to do? ");
                response = Console.ReadLine() ?? String.Empty;
                
            }
            switch(response){
                case "5":
                    Environment.Exit(0);
                    break;
                case "1":
                _prompt.GetPrompt();
                DateTime dateAndTime = DateTime.Now;
                string entry = Console.ReadLine() ?? String.Empty;

                _journal.CreateEntry(new Entry(entry,dateAndTime));
                    

                break;
                case "2":
                _journal.ShowEntries();
                    
                break;
                case "3":
                    
                break;
                case "4":
                

                break;




            }
            response = "";

        }
    }

}