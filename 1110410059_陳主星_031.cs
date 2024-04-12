using System;
using System.Collections.Generic;

class Program
{
    static List<int> FindWordsWithCharacter(string[] words, char x)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(x))
            {
                result.Add(i);
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        string[] words = { "leet", "code" };
        char x = 'e';
        List<int> indices = FindWordsWithCharacter(words, x);
        foreach (int index in indices)
        {
            Console.WriteLine(index);
        }
    }
}
