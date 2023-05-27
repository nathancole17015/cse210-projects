public class Word{

private string _word = "";

private Boolean _shown;

 public Word(string word){
    _word = word;
    _shown =false;
  
 }

public string  GetWord(){
    return _word;

}

public string HideWord(){
    return "_";
}
}
