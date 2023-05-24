public class Team{

    private List<Player> _players = new List<Player>();
    private string _name = "";

    private int _win;
    private int _loss;



    public Team(string name){
        _name = name;

    }
    public void AddPlayer (Player p){
        _players.Add(p);
    }

    public void DisplayRoster(){
        foreach(Player player in _players) {
            Console.WriteLine(player.Display());
        }
    }

public void AddWin(){
    // _wins += 1;
}
public void AddLoss(){
    _loss += 1;
}
// public string ReturnRecord(){
    // return $"{_wins}/{_loss}";
}
// }