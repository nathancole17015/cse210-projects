// See https://aka.ms/new-console-template for more information

Book mistborn = new Book("Mistborn", "Brandon Sanderson");

Book DiaryOfaWimpyKid = new Book("Diary of a Wimpy Kid", "Jeff Kinney");


mistborn.Display();

DiaryOfaWimpyKid.Display();

Console.WriteLine(mistborn.IsAvailable());