using System;

public class Solution {
    public string solution(int a, int b) {
        string answer;
        DateTime date = new DateTime(2016, a, b);
        DayOfWeek dayOfWeek = date.DayOfWeek;

        switch (dayOfWeek)
        {
            case DayOfWeek.Sunday:
                answer = "SUN";
                break;
            case DayOfWeek.Monday:
                answer = "MON";
                break;
            case DayOfWeek.Tuesday:
                answer = "TUE";
                break;
            case DayOfWeek.Wednesday:
                answer = "WED";
                break;
            case DayOfWeek.Thursday:
                answer = "THU";
                break;
            case DayOfWeek.Friday:
                answer = "FRI";
                break;
            case DayOfWeek.Saturday:
                answer = "SAT";
                break;
            default:
                answer = ("요일을 찾을 수 없습니다.");
                break;
        }

        return answer;
    }
}