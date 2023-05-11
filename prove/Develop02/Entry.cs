
public class Entry{

    private DateTime _dateAndTime;
    private string _entry;
    public Entry(string entry,DateTime dateAndTime){
            _entry = entry;
            _dateAndTime = dateAndTime;

    }
    Prompt prompt = new Prompt();
   

    
    
    
    
    
    public string GetEntry(){
        return $"{_dateAndTime}---{_entry}";
    }
  
    }
    