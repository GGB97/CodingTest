using System.Text;

public class Solution {
    public string solution(string s)
    {
        StringBuilder str = new StringBuilder();

        int i =0;
        foreach(char c in s)
        {
            if (c == ' '){
                i = 0;
                str.Append(c);
            }
            else if(i++ % 2 ==0)
                str.Append(char.ToUpper(c));
            else
                str.Append(char.ToLower(c));
        }

        return str.ToString();
    }
}