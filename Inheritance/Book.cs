public class Book : Loanable{

private string _title;

private string _isbn;

private int _upc;

public Book(string title, string isbn, int upc){

        _title = title;
        _isbn = isbn;
        _upc = upc;

}

    public void ShowBookDetail(){
            Console.WriteLine($"{_title}: {_isbn} :: {_upc}");
    }
    public override void Display()
    {
        base.Display();
        ShowBookDetail();
    }
}