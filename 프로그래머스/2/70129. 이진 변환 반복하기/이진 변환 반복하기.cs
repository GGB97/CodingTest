using System;
using System.Linq;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2]; // 0 -> 변환 횟수 1 -> 제거한 0의 숫자
        string modifiedString;

        while (s.Length != 1)
        {
            modifiedString = new string(s.Where(c => c != '0').ToArray());
            answer[1] += s.Length - modifiedString.Length;
            s = Convert.ToString(modifiedString.Length, 2);
            answer[0]++;
        }

        return answer;
    }
}