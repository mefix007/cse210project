// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Reference reference = new Reference("Proverbs", 3, 5, 6);
//         string text = "Trust in the Lord with all your heart and lean not on your own understanding.";
//         Scripture scripture = new Scripture(reference, text);

//         while (true)
//         {
//             Console.Clear();
//             Console.WriteLine(scripture);

//             if (scripture.IsFullyHidden())
//             {
//                 Console.WriteLine("\nAll words have been hidden.");
//                 break;
//             }
//             Console.Write("\nPress Enter to continue or type 'quit' to exit: ");
//             string input = Console.ReadLine()?.Trim().ToLower();
//             if (input == "quit")
//             {
//                 break;
//             }

//             scripture.HideRandomWords(3);
//         }
//         static void ClearConsole()
//         {
//             Console.Clear();
//         }
//     }

//     public class Reference
//     {
//         private string _book;
//         private int _chapter;
//         private int _verse;
//         private int _endVerse;

//         public Reference(string book, int chapter, int verse)
//         {
//             _book = book;
//             _chapter = chapter;
//             _verse = verse;
//         }
//         public Reference(string book, int chapter, int startVerse, int endVerse)
//         {
//             _book = book;
//             _chapter = chapter;
//             _verse = startVerse;
//             _endVerse = endVerse;
//         }
//         public string GetDisplayText1()
//         {
//             return SingleVerse();
//         }
//         private string SingleVerse()
//         {
//             return $"{_book} {_chapter}:{_verse}";

//         }
//         public string GetDisplayText2()
//         {
//             return VerseRange();
//         }
//         private string VerseRange()
//         {
//             return $"{_book} {_chapter}:{_verse}-{_endVerse}";

//         }

//     }
//     public class Word
//     {
//         private string _text;
//         private bool _isHidden;

//         public Word(string text)
//         {
//             _text = text;
//             _isHidden = false;
//         }
//         public void Hide()
//         {
//             _isHidden = true;
//         }
//         public void Show()
//         {
//             _isHidden = false;
//         }
//         public bool IsHidden()
//         {
//             return _isHidden;
//         }
//         public string GetDisplayText()
//         {
//             return $"{_text} {_isHidden}";
//         }

//     }
//     public class Scripture
//     {
//         private Reference _reference;
//         private List<Word> _words;

//         public Scripture(Reference Reference, string text)
//         {
//             _reference = Reference;
//             _words = text.Split(' ').Select(word => new Word(word)).ToList();
//         }
//         public void HideRandomWords(int numberToHide)
//         {
//             _words = _words.Where(Word => !_words.IsHidden).ToList();
//             if (_words.Count == 0) return;

//             Random random = new Random();
//             int wordsToHide = Math.Min(count, _words.Count)
//             var SelectedWords = _words.OrderBy(_ => random.Next()).Take(wordsToHide);

//             foreach (var word in SelectedWords)
//             {
//                 word.Hide();
//             }
//         }
//         public bool IsFullyHidden()
//         {
//             return _words.All(word => word.IsHidden);
//         }
//         public override string ToString()
//         {
//             string _words = String.Join(" ", Words);
//             return $"{_reference}\n{_words}";
//         }
//     }
// }

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the reference and scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "5. Trust in the LORD with all thine heart; and lean not unto thine own understanding.\n6. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, text);

        // Main game loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);

            // Check if all words are hidden, and if so, end the program
            if (scripture.IsFullyHidden())
            {
                Console.WriteLine("\nAll words have been hidden.");
                break;
            }

            // Prompt the user for input
            Console.Write("\nPress Enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine()?.Trim().ToLower();
            if (input == "quit")
            {
                break;
            }

            // Hide random words and continue
            scripture.HideRandomWords(2);

        }
        Console.WriteLine("\nWeldone! you have completed the Scripture memorizer successfully.");

    }
}

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor for single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Constructor for verse range
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Display for single verse
    public string GetDisplayText1()
    {
        return SingleVerse();
    }

    private string SingleVerse()
    {
        return $"{_book} {_chapter}:{_verse}";
    }

    // Display for verse range
    public string GetDisplayText2()
    {
        return VerseRange();
    }

    private string VerseRange()
    {
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }

    // Override ToString for default reference display
    public override string ToString()
    {
        if (_endVerse > 0)
        {
            return VerseRange();
        }
        return SingleVerse();
    }
}

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    // Get word display text, hiding it if necessary
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Hide a specified number of random words
    public void HideRandomWords(int numberToHide)
    {
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        if (visibleWords.Count == 0) return;

        Random random = new Random();
        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);
        var selectedWords = visibleWords.OrderBy(_ => random.Next()).Take(wordsToHide);

        foreach (var word in selectedWords)
        {
            word.Hide();
        }
    }

    // Check if all words are hidden
    public bool IsFullyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    // Convert scripture to string
    public override string ToString()
    {
        string wordText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference}\n{wordText}";
    }
}
