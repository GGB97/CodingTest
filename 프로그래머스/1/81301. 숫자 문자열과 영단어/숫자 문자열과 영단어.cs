using System;
using System.Text;

public class Solution {
    public int solution(string s) {
        StringBuilder sb = new StringBuilder(s);
        string[] numStr = 
        { "zero", "one", "two", "three", "four", 
         "five", "six", "seven", "eight", "nine" };


        for(int i =0; i < numStr.Length; i++)
        {
            sb.Replace(numStr[i], i.ToString());
        }

        return int.Parse(sb.ToString());
    }
}