using System.Text;

public class Solution {
    public string solution(string s, int n) {
        int asc;
        StringBuilder sb = new StringBuilder();

        foreach (char c in s)
        {
            asc = (int)c;
            if(65 <= asc && asc <= 90)
            {
                asc += n;
                if (90 < asc)
                    asc -= 26;
            }
            else if (97 <= asc && asc <=122)
            {
                asc += n;
                if (asc > 122)
                    asc -= 26;
            }
            else if (asc - n == 32)
                asc = 32;

            sb.Append((char)asc);
        }

        return sb.ToString();
    }
}