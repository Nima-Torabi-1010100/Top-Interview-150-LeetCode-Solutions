public class Solution {
    public string IntToRoman(int num) {
            int[] values = { 1, 5, 10, 50, 100, 500, 1000 };
            char[] symbols = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            string result = "";
            string _result;           
            int number = 0, coefficient = 0, indexValue = 0;
            while (num > 0)
            {
                coefficient = (int)Math.Pow(10, num.ToString().Length - 1);
                number = (num / coefficient) * coefficient;
                num -= number;
                if (number.ToString().Contains("4") || number.ToString().Contains("9"))
                {
                    _result = "";
                    while (number > 0)
                    {
                        indexValue = Array.IndexOf(values, values.FirstOrDefault(p => p >= number));
                        _result += symbols[indexValue];
                        number = values[indexValue] - number;
                    }
                    result += ReverseStr(_result);
                }
                else
                {
                    while (number > 0)
                    {
                        indexValue = Array.IndexOf(values, values.LastOrDefault(p => p <= number));
                        result += symbols[indexValue];
                        number -= values[indexValue];
                    }
                }
            }
            return result;
    }
    public static string ReverseStr(string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}
