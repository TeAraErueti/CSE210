using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private Word scriptureText;
    private List<string> _words = new();

    private List<string> _hiddenWords = new();
    private string[] _text;

    public Scripture(Reference reference)
    {
        _reference = reference;
        _text = _reference.GetVerse().Split(" ");
        foreach (string word in _text)
        {
            scriptureText = new Word(word);
            _words.Add(scriptureText.GetHideText());
        }
    }

    public void HideRandomWords (int numberToHide)
    {
        Random random = new();

        for (int i = 0; i < numberToHide; i++)
        {
            int randomNumber = random.Next(_words.Count());
            string removeWord = _words[randomNumber];

            if (removeWord != "________")
            {
                _hiddenWords.Add(removeWord);
            }

            if (removeWord == "________")
            {
                randomNumber = random.Next(_words.Count());
            }

            _words.RemoveAt(randomNumber);
            scriptureText.Hide();
            _words.Insert(randomNumber, scriptureText.GetHideText());
        }
    }

    public bool IsCompletelyHidden()
    {
        bool isIt = false;
        bool result = _words.All(word => word == "________");
        if (result)
        {
            isIt = true;
        }
        return isIt;
    }

    public void DisplayText()
    {
        string theref = _reference.GetDisplayText();
        Console.WriteLine($"\n{theref}\n{string.Join(" ", _words)}\n");   
    }
}