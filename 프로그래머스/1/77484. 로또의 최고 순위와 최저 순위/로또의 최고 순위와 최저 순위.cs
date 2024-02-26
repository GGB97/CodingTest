using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int rank = 7;
        int zeroCnt = 0;

        for (int i = 0; i < lottos.Length; i++)
        {
            if (lottos[i] == 0)
            {
                zeroCnt++;
            }
            else
            {
                if (Array.IndexOf(win_nums, lottos[i]) != -1)
                    rank--;
            }
        }
        
        
        rank = rank > 6 ? 6 : rank;
        answer[0] = rank - zeroCnt;
        if (answer[0] == 0)
            answer[0]++;
        answer[1] = rank;

        return answer;
    }
}