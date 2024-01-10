public class Solution {
    public int solution(string s) {
        int answer = 0;
        string str = s.Substring(0, 1);


        if(str == "-")
        {
            answer = -(int.Parse(s.Substring(1, s.Length - 1)));
        }
        else if (str == "+")
        {
            answer = int.Parse(s.Substring(1, s.Length - 1));
        }
        else
        {
            answer = int.Parse(s);
        }
        
        return answer;
    }
}