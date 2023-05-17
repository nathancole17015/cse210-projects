// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Team awesomeSauce = new Team("Awesome Sauce" );
Player Neymar = new Player("Neymar jr", 10,"Forward");

Player Kobe = new Player ("Kobe Bryant", 24, "");


awesomeSauce.AddPlayer(Kobe);
awesomeSauce.AddPlayer(Neymar);

awesomeSauce.AddLoss();
awesomeSauce.AddWin();

awesomeSauce.DisplayRoster();
awesomeSauce.ReturnRecord();