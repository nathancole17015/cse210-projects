
public class Scripture{
    
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string words){

        _reference = reference;
        _words = WordsToList(words) ;





    }
    private List<Word> WordsToList(string word){
        string [] splitWord = word.Split(" ");
        List<Word> listOfWords = new List<Word>();
        foreach (string split in splitWord){

            listOfWords.Add(new Word(split));
        }
      
        return listOfWords;
    }

    public void HideRandWord(){
  {
    var random = new Random();
    int randomNumber = random.Next(_words.Count);
    string hiddenWordText = _words[randomNumber].GetWord();
    Word hiddenWord = new Word(hiddenWordText);
    // hiddenWord.HideWord();
    Word WordHidden =  new Word("_____");
   
    if (hiddenWord !=  WordHidden){
    _words[randomNumber] = hiddenWord;
    _words.Remove(hiddenWord);
    _words.Insert(randomNumber,WordHidden);
    }
    
  
}

    
        
    }
    
        

      
    
    public void Display(){
         string response = "";
        string[] options = {"quit",""};
        
        while (response != "quit"){
        Console.Clear();
        Console.WriteLine(_reference.DisplayReference());
          foreach(Word word in _words){
        
            Console.Write(word.GetWord() + " ");
            }
        
        HideRandWord();
        Console.WriteLine($"\nPress Enter to continue or type 'quit' to exit.");
        response = Console.ReadLine();

        }
           
           

           
        }
     
        

        

            
    }



