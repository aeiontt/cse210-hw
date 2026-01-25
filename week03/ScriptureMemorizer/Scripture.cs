using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    // Attributes using encapsulation (private with underscores)
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        // Split the text into individual words
        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            // Create a new Word object for each string and add to the list
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        // Stretch Challenge: Only pick words that are not already hidden
        List<Word> availableWords = _words.Where(w => !w.IsHidden()).ToList();

        // Hide words based on the number requested or what is left available
        for (int i = 0; i < numberToHide && availableWords.Count > 0; i++)
        {
            int index = random.Next(availableWords.Count);
            availableWords[index].Hide();
            availableWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        // Combine the reference and all word display texts
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        // Check if all words in the list are hidden
        return _words.All(w => w.IsHidden());
    }
}