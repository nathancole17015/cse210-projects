public class Video{
private string _title;
private string _author;
private int _length;
List<Comments> _comments = new List<Comments>();
public Video(string title, string author, int length, List<Comments> comments){
    _title = title;
    _author = author;
    _length = length;
}
public void Display(){
Console.WriteLine();
Console.WriteLine("===================================");
Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length}, Number of Comments: {_comments.Count()} ");
Console.WriteLine();
Console.WriteLine("Comments: ");
Console.WriteLine();
GetComments();
Console.WriteLine("===================================");
Console.WriteLine();
}
public void GetComments(){
    foreach (Comments line in _comments){
        Console.WriteLine(line.StringifyComment());
        Console.WriteLine();
    }
}
public void AddComment(Comments comment){
    _comments.Add(comment);
}
}