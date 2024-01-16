using System.Text;

public class Solution {
    public string solution(int n) {
        StringBuilder answer = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            answer.Append(i % 2 == 0 ? '수' : '박');
        }
        return answer.ToString();
    }
}