using System;
using System.Text;

public class Solution {
    public string solution(string x, string y)
    {
        string answer = "0";
        int[] cx = Search(x);
        int[] cy = Search(y);
        int[] ca = Compare(cx, cy);

        bool isZero = true;
        for(int i = 1; i < ca.Length; i++)
        {
            if (ca[i] != 0)
            {
                isZero = false;
            }
        }

        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < ca.Length; i++)
        {
            if (ca[i] != 0)
            {
                for(int j = 0; j < ca[i]; j++)
                {
                    sb.Append(i);
                }
            }
        }

        if(sb.Length == 0)
            answer = "-1";
        else if(!isZero)
        {
            char[] charArray = sb.ToString().ToCharArray();
            Array.Sort(charArray);
            Array.Reverse(charArray);
            charArray.ToString();
            answer = new string(charArray);
        }
        return answer;
    }

    public int[] Search(string str)
    {
        int num = 0;
        int[] arr = new int[10];
        foreach (char c in str)
        {
            num = int.Parse(c.ToString());
            arr[num] += 1;
        }
        return arr;
    }

    public int[] Compare(int[] xa, int[] ya)
    {
        int[] answer = new int[10];
        for(int i = 0; i < xa.Length; i++)
        {
            answer[i] = xa[i] >= ya[i] ? ya[i] : xa[i];
        }
        return answer;
    }
    
}