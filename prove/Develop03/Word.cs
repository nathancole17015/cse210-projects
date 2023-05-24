public class Word{

private string _word = "";
Boolean _shown = true;

 public Word(string word){
    _word = word;
 }

public void DisplayWord(){
    Console.Write(_word);
}

}