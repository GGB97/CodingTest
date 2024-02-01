using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
     
        List<int> daysUntil = new List<int>();

        for (int i = 0; i < progresses.Length; i++) {
            int days = (int)Math.Ceiling((double)(100 - progresses[i]) / speeds[i]);
            daysUntil.Add(days);
        }

        List<int> result = new List<int>();
        int idx = 0;

        while (idx < daysUntil.Count) {
            int cnt = 0;
            int currentDay = daysUntil[idx];

            while (idx < daysUntil.Count && daysUntil[idx] <= currentDay) {
                cnt++;
                idx++;
            }

            result.Add(cnt);
        }

        return result.ToArray();
        
    }
}