public class Solution {
    public string solution(string s, int n) {

                string answer = "";
                char[] temp = s.ToCharArray();
                for(int i = 0; i < s.Length; ++i)
                {
                    if ( (temp[i] >= 'a' && temp[i] <= 'z')|| (temp[i] >= 'A' && temp[i] <= 'Z'))
                    {
                        if (char.IsUpper(temp[i]))
                        {
                            temp[i] = (char)((temp[i] + n - 'A') % 26 + 'A');
                        }
                        else
                        {
                            temp[i] = (char)((temp[i] + n - 'a') % 26 + 'a');
                        }
                    }
                }
                return new string(temp);
    }
}