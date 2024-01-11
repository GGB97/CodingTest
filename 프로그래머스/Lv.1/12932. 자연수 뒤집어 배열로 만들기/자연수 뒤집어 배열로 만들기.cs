public class Solution {
    public int[] solution(long n) {
        string str = n.ToString();
        int[] answer = new int[str.Length];

        for (int i = 0, cnt = str.Length -1; i < str.Length; i++)
        {
            answer[i] = (int)char.GetNumericValue(str[cnt--]);
        }

        return answer;
    }
}