// See https://aka.ms/new-console-template for more information

Source source = new Source("None Were with Him", "http://www.churchofjesuschrist.org");

//Console.WriteLine(source.Stringify());

Quote holland = new Quote("Jeffery Holland","Because Jesus walked such a long, lonely path utterly alone, wee do not have to do so", source);

//Console.WriteLine(holland.GetQuote());

Board quoteboard = new Board();

quoteboard.AddQuote(
new Quote("Paul",
"God hath not given us the spirit of fear; but of power, and of love, and of a sound mind. ",
new Source("2 Timothy 1:7")

)
);

quoteboard.AddQuote(
new Quote("Sister Elaine S. Dalton",
"Work hard to achieve your dreams. Don't let discouragement or mistakes delay",
new Source("How to Dare Great Things", "https://www.churchofjesuschrist.org/study/new-era/2012/03/how-to-dare-great-things?lang=eng" )

)
);

quoteboard.AddQuote(
new Quote("Alma",
"If ye have faith ye hope for things which are not seen, which are true",
new Source("Alma 32:21")
    )
);

quoteboard.AddQuote(
new Quote("Alma",
"Live in thanksgiving daily"
,new Source("Alma 34:38")
    )
);
quoteboard.AddQuote(
new Quote("Alma",
"Counsel with the Lord in all thy doings, and he will direct thee for good"
, new Source("Alma 34:38")
    )
);

quoteboard.GetRandomQuote();
//
Menu _menu = new Menu(quoteboard);
_menu.Display();