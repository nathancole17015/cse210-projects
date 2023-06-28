public class Comments{

private string _author;
private string _comment;


public Comments(string author, string comment){
    _author = author;
    _comment = comment;
}

public string StringifyComment(){
    return $"{_author} --- {_comment}";
}

}


