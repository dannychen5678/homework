using System;
using System.Collections.Generic;

class Program
{
    static string IntToRoman(int num)
    {
        // 定義一個字典，將整數和對應的羅馬數字符號進行映射
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

        // 儲存轉換後的羅馬數字的結果
        string result = "";

        // 遍歷字典中的每一對鍵值對
        foreach (var kvp in romanNumerals)
        {
            // 當輸入的數字大於等於當前鍵值對的鍵時，進行處理
            while (num >= kvp.Key)
            {
                // 將當前鍵值對的值添加到結果中
                result += kvp.Value;
                // 減去已處理的鍵值對的鍵
                num -= kvp.Key;
            }
        }
        // 返回轉換後的羅馬數字結果
        return result;
    }

    static void Main(string[] args)
    {
        // 測試範例
        Console.WriteLine(IntToRoman(3));    // 輸出 "III"
        Console.WriteLine(IntToRoman(58));   // 輸出 "LVIII"
        Console.WriteLine(IntToRoman(1994)); // 輸出 "MCMXCIV"
    }
}
