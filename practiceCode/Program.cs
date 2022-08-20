using static System.Console;

class Sentence
{
    string[] words = "The quick brown fox.".Split();

    public string this[int wordNum]
    {
        get { return words[wordNum]; }
        set { words[wordNum] = value; }
    }

    static void Main()
    {
        Sentence s = new Sentence();
        WriteLine(s[3]);
        s[3] = "kangaroo";
        WriteLine(s[3]);
    }
}