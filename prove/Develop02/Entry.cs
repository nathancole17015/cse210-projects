
public class Entry{

    private DateTime _dateAndTime;
    private string _prompt;
    private string _entry;
    
    public Entry(string entry,DateTime dateAndTime, string prompt){
            _entry = entry;
            _dateAndTime = dateAndTime;
            _prompt = prompt;

    }
    
   

    
    
    
    
    
    public string GetEntry(){
        return $"{_dateAndTime}--Prompt:{_prompt}--> {_entry}";
    }
  
    }
    