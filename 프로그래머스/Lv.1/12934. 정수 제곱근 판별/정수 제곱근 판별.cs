using System;
public class Solution {
    public long solution(long n)
    {
        long answer = (long)Math.Sqrt(n);

        if (answer * answer == n)
        {
            answer = (answer + 1) * (answer + 1);
        }
        else
        {
            answer = -1;
        }

        return answer;
    }
}