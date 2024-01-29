using System;

public class Solution {
    public int[] solution(int n, long left, long right) {
       int[] answer = new int[right - left + 1];

       long row, col;
       for (long i = left, cnt = 0; i <= right; i++)
       {
           row = i / n; 
           col = i % n;
           answer[cnt++] = (int)(row > col ? row + 1 : col + 1);
       }

       return answer;
    }
}