
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
            
            response = "";
            while(options.Contains(response)==false)
            {
                Console.Write("\n1.Write:\n2.Display\n3.Load\n4.Save\n5.Quit\n\nWhat do you want to do? ");
                response = Console.ReadLine() ?? String.Empty;
            
            switch(response){
                case "5":
                    Environment.Exit(0);
                    break;
                case "1":                   
                    string prompt = _prompt.GetPrompt();
                    Console.WriteLine($"\n{prompt}\n");
                    DateTime dateAndTime = DateTime.Now;
                    Console.Write("> ");
                    string entry = Console.ReadLine() ?? String.Empty;

                    _journal.CreateEntry(new Entry(entry,dateAndTime,prompt));
                    
                    break;
                case "2":
                    string filename =  _journal.GetJournal();
                  _journal.ReadJournal(filename);

                break;
                case "3":
                    Console.Write("Name of file you want to load: ");
                    string SaveFilename = Console.ReadLine();
                    _journal.CreateJournal(SaveFilename);
                    
                    
                    
                break;
                case "4":
                    Console.Write("Name of file you want to save: ");
                   string Filename = Console.ReadLine();
                   _journal.SaveEntry(Filename);


                break;
            }
            response = "";

        }
    }
    }

}