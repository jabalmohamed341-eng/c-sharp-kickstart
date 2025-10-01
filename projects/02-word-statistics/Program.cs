// Project 2: Word Statistics Analyzer
// A comprehensive text analysis application using methods, lists, and dictionaries

using System;
using System.Collections.Generic;

// TODO: Create text input method

partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("📊 Word Statistics Analyzer");
        Console.WriteLine("===========================");
        Console.WriteLine("");

        bool analyzeMore = true;
        while (analyzeMore)
        {
            // TODO: Get text input
            List<string> inputLines = GetTextInput();
            string fullText = string.Join(" ", inputLines);

            // TODO: Process text
            List<string> words = ExtractWords(fullText);
            Dictionary<string, int> wordFrequency = CountWordFrequency(words);

            Console.WriteLine("");
            Console.WriteLine("Text Analysis Report");
            Console.WriteLine("===================");
            Console.WriteLine("");

            // TODO: Display input text
            Console.WriteLine("Input Text:");
            Console.WriteLine("----------");
            Console.WriteLine(fullText);
            Console.WriteLine("");

            // TODO: Display basic statistics
            DisplayBasicStatistics(fullText, words);

            // TODO: Display word frequency
            DisplayWordFrequency(wordFrequency);

            // TODO: Display character analysis
            DisplayCharacterAnalysis(fullText);

            Console.WriteLine("");
            Console.WriteLine("Would you like to analyze another text? (yes/no):");
            string continueInput = Console.ReadLine().ToLower();
            analyzeMore = continueInput == "yes" || continueInput == "y";
            Console.WriteLine("");
        }

        Console.WriteLine("Thank you for using Word Statistics Analyzer!");
        static List<string> GetTextInput()
{
    var lines = new List<string>();
    Console.WriteLine("Enter text to analyze (type 'END' on a new line to finish):");
    
    string line;
    while ((line = Console.ReadLine()) != "END")
    {
        lines.Add(line);
    }
    
    return lines;
}

// TODO: Create word extraction method
static List<string> ExtractWords(string text)
{
    string cleanText = "";
    foreach (char c in text)
    {
        if (char.IsLetter(c) || char.IsWhiteSpace(c))
            cleanText += c;
        else
            cleanText += " ";
    }
    
    string[] wordArray = cleanText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    var words = new List<string>();
    
    foreach (string word in wordArray)
    {
        words.Add(word.ToLower());
    }
    
    return words;
}

// TODO: Create frequency analysis method
static Dictionary<string, int> CountWordFrequency(List<string> words)
{
    Dictionary<string, int> frequency = new Dictionary<string, int>();
    
    foreach (string word in words)
    {
        if (frequency.ContainsKey(word))
            frequency[word]++;
        else
            frequency[word] = 1;
    }
    
    return frequency;
}

// TODO: Create statistical methods
static double CalculateAverageWordLength(List<string> words)
{
    if (words.Count == 0) return 0.0;
    
    int totalLength = 0;
    foreach (string word in words)
    {
        totalLength += word.Length;
    }
    
    return (double)totalLength / words.Count;   
}
static string FindLongestWord(List<string> words)
{
    string longest = "";
    foreach (string word in words)
    {
        if (word.Length > longest.Length)
            longest = word;
    }
    return longest; 
}
static string FindShortestWord(List<string> words)
{
    if (words.Count == 0) return "";
    
    string shortest = words[0];
    foreach (string word in words)
    {
        if (word.Length < shortest.Length)
            shortest = word;
    }
    return shortest; 
}
static int CountVowels(string text)
{
    int count = 0;
    foreach (char c in text.ToLower())
    {
        if ("aeiou".Contains(c))
            count++;
    }
    return count; 
}
static int CountConsonants(string text)
{
    int count = 0;
    foreach (char c in text.ToLower())
    {
        if ("bcdfghjklmnpqrstvwxyz".Contains(c))
            count++;
    }
    return count;
}
static int CountSentences(string text)
{
    int count = 0;
    bool inSentence = false;
    foreach (char c in text)
    {
        if (char.IsLetter(c))
        {
            inSentence = true;
        }
        else if (inSentence && (c == '.' || c == '!' || c == '?'))
        {
            count++;
            inSentence = false;
        }
    }
    return count;
}

// TODO: Create display methods
static void DisplayBasicStatistics(string text, List<string> words)
{
    Console.WriteLine("Basic Statistics:");
    Console.WriteLine("-----------------");
    Console.WriteLine($"Total Words: {words.Count}");
    Console.WriteLine($"Average Word Length: {CalculateAverageWordLength(words):F2}");
    Console.WriteLine($"Longest Word: {FindLongestWord(words)}");
    Console.WriteLine($"Shortest Word: {FindShortestWord(words)}");
    Console.WriteLine($"Total Vowels: {CountVowels(text)}");
    Console.WriteLine($"Total Consonants: {CountConsonants(text)}");
    Console.WriteLine($"Total Sentences: {CountSentences(text)}");
}
static void DisplayWordFrequency(Dictionary<string, int> frequency)
{
    Console.WriteLine("Word Frequency:");
    Console.WriteLine("---------------");
    foreach (var pair in frequency)
    {
        Console.WriteLine($"{pair.Key}: {pair.Value}");
    }
}
static void DisplayCharacterAnalysis(string text)
{
    Console.WriteLine("Character Analysis:");
    Console.WriteLine("-------------------");
    Console.WriteLine($"Total Vowels: {CountVowels(text)}");
    Console.WriteLine($"Total Consonants: {CountConsonants(text)}");
    Console.WriteLine($"Total Sentences: {CountSentences(text)}");
}
    }
}

        
