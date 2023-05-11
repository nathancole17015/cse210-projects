public class Journal{

    List<Entry> _entries = new List<Entry>();
    List<Prompt>_prompt = new List<Prompt>();
    public Journal(){

    }
     private void NicePrint(string item){
    
        Console.WriteLine($"{item}");
       }
     public void GetRandomPrompt(){
        var random = new Random();
        var randomNumber = random.Next(0,_prompt.Count);
        Console.WriteLine(_prompt[randomNumber]);


    }
   public void CreateEntry(Entry entry)
    {   
        _entries.Add(entry);
        
        }

    public void ShowEntries(){
        foreach (Entry entry in _entries){
            Console.WriteLine(entry.GetEntry());
        }
    }
    
    public void AddEntry(Entry entry){
        _entries.Add(entry);
    }


   
        
    }
    