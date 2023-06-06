using System;
using System.Collections.Generic;
using System.Text;

class Word
{
    public string Text { get; set; }
    public bool Hidden { get; set; }

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }
}

class Reference
{
    public string Book { get; set; }
    public int Chapter { get; set; }
    public string Verse { get; set; }

    public Reference(string book, int chapter, string verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    public override string ToString()
    {
        return $"{Book} {Chapter}:{Verse}";
    }
}

class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private Random _random;

    public Scripture(Reference reference, string words)
    {
        _reference = reference;
        _words = ConvertWordsToList(words);
        _random = new Random();
    }

    private List<Word> ConvertWordsToList(string words)
    {
        string[] splitWords = words.Split(" ");
        List<Word> wordList = new List<Word>();
        foreach (string word in splitWords)
        {
            wordList.Add(new Word(word));
        }
        return wordList;
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference);

        StringBuilder scriptureText = new StringBuilder();
        foreach (Word word in _words)
        {
            if (word.Hidden)
            {
                string hiddenText = new string('_', word.Text.Length);
                scriptureText.Append(hiddenText + " ");
            }
            else
            {
                scriptureText.Append(word.Text + " ");
            }
        }

        Console.WriteLine(scriptureText.ToString() + "\n");
    }

    public void HideRandomWord()
    {
        List<Word> visibleWords = _words.FindAll(word => !word.Hidden);
        int randomIndex = _random.Next(visibleWords.Count);
        visibleWords[randomIndex].Hidden = true;
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.Hidden)
            {
                return false;
            }
        }
        return true;
    }

    public void Memorize()
    {
        Display();

        while (true)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            HideRandomWord();
            Display();

            if (AllWordsHidden())
            {
                break;
            }
        }
    }
}

