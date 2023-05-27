public class Reference{
   private string _book = "";
   private int _startVerse;
    private int _endVerse;
    private int _chapter;

    public Reference(string book,int chapter,int startVerse, int endVerse){

        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string DisplayReference(){
       if (_endVerse == _startVerse){
             return $"{_book} {_chapter}:{_startVerse}";

       }
       else{

                return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";

       }
       
    }



}