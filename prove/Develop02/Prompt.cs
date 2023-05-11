public class Prompt{

        
            List<string>_prompts = new List<string>();

        private string _prompt;
   
    public Prompt(){
        
        _prompts.Add("How was your day? ");
        _prompts.Add("What was a highlight of your day?");
        _prompts.Add("What was a low of your day?");
        _prompts.Add("What are somethings you want to change?");
        _prompts.Add("What are somethings that are making you happy?");
        _prompts.Add("Something new you learned today?");
    }

      public string GetPrompt(){
    
        var random = new Random();
        int randomNumber = random.Next(0,_prompts.Count);
        return $"{_prompts[randomNumber]} ";
        
    
      }
     
    }
    
   
   
