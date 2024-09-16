public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs[0] == "")
        {
            return "";
        }
        string result = "";
        string fWord = strs[0];
        int index = 0;
        bool isCommonPrefix = true;
        while (isCommonPrefix && index < fWord.Length)
        {
            for (int i = 1; i < strs.Length; i++)
            {
                if (index < strs[i].Length && fWord[index] == strs[i][index])
                {
                    isCommonPrefix = true;
                }
                else
                {
                    isCommonPrefix = false;
                    break;
                }
            }
            if (!isCommonPrefix)
            {
                break;
            }
            result += fWord[index];
            index++;
        }
        return result;
    }
}
