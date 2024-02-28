using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        int boxCount = score.Length / m;

        Array.Sort(score);
        Array.Reverse(score);

        int[,] apples = new int[boxCount, m];
        for (int i = 0, cnt = 0; i < boxCount; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
                apples[i, j] = score[cnt++];
            }
        }

        for (int i = 0; i < apples.GetLength(0); i++)
        {
            answer += apples[i, m - 1] * m;
        }

        return answer;
    }
}