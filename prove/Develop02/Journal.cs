using System.IO; 

public class Journal{

    List<string> _journals = new List<string>();
    List<Entry> _entries = new List<Entry>();
    List<Prompt>_prompt = new List<Prompt>();
    public Journal(){
        _journals.Add("");
    }
     
 
   public void CreateEntry(Entry entry){
   
        
        _entries.Add(entry);
        
   }

    public void CreateJournal(string journal){
        _journals.RemoveAt(0);
        _journals.Add(journal);

    }
    public string GetJournal(){
        return _journals[0];
        }
    

    public void ShowEntries(){
        Console.WriteLine($"\nJournal Entries:\n");
        foreach (Entry entry in _entries){
            Console.WriteLine($"{entry.GetEntry()}\n");
        }
    }
     public void SaveEntry(string filename)

    {   
        using (StreamWriter outputFile = new StreamWriter(filename)){

            foreach (Entry entry in _entries){
            outputFile.WriteLine($"|{entry.GetEntry()}|\n");  
        }

        }
    }
    public void ReadJournal(string filename){
          if (filename == ""){
            Console.WriteLine($"\nJournal Entries:\n");
            foreach (Entry entry in _entries){
            Console.WriteLine($"{entry.GetEntry()}\n");
        }
          }
        else{
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines){   
        

            Console.WriteLine(line);
        
            }
        }
    }
    
}
    