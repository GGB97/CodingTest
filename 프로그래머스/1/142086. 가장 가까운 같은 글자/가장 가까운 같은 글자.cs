using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s)
    {
        int[] answer = new int[s.Length];
        Dictionary<char, List<int>> dic = new Dictionary<char, List<int>>();

        for (int i = 0; i < s.Length; i++)
        {
            if (dic.ContainsKey(s[i]))
            {
                dic[s[i]].Add(i);
            }
            else
            {
                dic.Add(s[i], new List<int>());
                dic[s[i]].Add(i);
            }
        }

        int n = 0;
        List<int> numList;
        for (int i = 0; i < s.Length; i++)
        {
            numList = dic[s[i]];
            n = 0;

            for (int j = 0; j < numList.Count; j++)
            {
                if (numList[j] == i)
                {
                    answer[i] = answer[i] == j ? (-1) : (i - n);
                    break;
                }
                else
                {
                    n = int.Parse(numList[j].ToString());
                }
            }
        }
        return answer;
    }
}