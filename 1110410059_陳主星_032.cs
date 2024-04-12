using System;
using System.Collections.Generic;

class Program
{
    static string IntToRoman(int num)
    {
        Dictionary<int, string> romanNumerals = new Dictionary<int, string>()
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };

        string result = "";
        foreach (var kvp in romanNumerals)
        {
            while (num >= kvp.Key)
            {
                result += kvp.Value;
                num -= kvp.Key;
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(IntToRoman(3));    // 輸出 "III"
        Console.WriteLine(IntToRoman(58));   // 輸出 "LVIII"
        Console.WriteLine(IntToRoman(1994)); // 輸出 "MCMXCIV"
    }
}
