List<Comments> FiveSecondHacks = new List<Comments>();
Comments helpFull = new Comments("rick", "Wow! this was so helpful");
Comments soDumb = new Comments("Rodrigo", "This was so dumb");
Comments KnowItAll = new Comments("padre", "My dad already knows how to do this");


Video fiveSecond = new Video("Five second hacks","this is video shows helpful 5 second life hacks",120,FiveSecondHacks);
fiveSecond.AddComment(helpFull);
fiveSecond.AddComment(soDumb);
fiveSecond.AddComment(KnowItAll);

fiveSecond.Display();

