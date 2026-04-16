namespace Anagram.Application;

class Program
{
    static void Main(string[] args)
    {
        string exampleText = "a1bcd efg!h";
        AnagramChecker anagramChecker = new();
        string result = anagramChecker.ReverseWords(exampleText);

        Console.WriteLine(result);
    }
}