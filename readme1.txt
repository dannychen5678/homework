class Program
{
    static List<int> FindWordsWithCharacter(string[] words, char x)/*帶入兩個參數分別是要判斷的字串陣列跟判斷的字元*/
    {
        List<int> result = new List<int>();/*創立一個list物件是泛型，用來存放我們具有判斷後且存在判斷字元的索引*/
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(x))/*如果判斷自原在裡面的話就把參數字串陣列的索引丟入我們新增的result裡面*/
            {
                result.Add(i);
            }
        }
        return result;
    }

    static void Main(string[] args)  /*我們執行的主程式*/
    {
        string[] words = { "leet", "code" };/*我們想要判斷的字串*/
        char x = 'e';/*用來判斷的字元*/
        List<int> indices = FindWordsWithCharacter(words, x);/*判斷的函示,如果有做判斷的字元有在我們的函市裡面的話就回傳回來,然後是以list動態陣列的型態並且是int*/
        foreach (int index in indices)/*把result裡面的值印出來*/
        {
            Console.WriteLine(index);
        }
    }
}
