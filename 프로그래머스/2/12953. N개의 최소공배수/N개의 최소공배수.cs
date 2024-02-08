public class Solution {
    public int solution(int[] arr)
    {
        int lcm = 1;
        foreach (int num in arr)
        {
            lcm = (lcm * num) / GCD(lcm, num);
        }
        return lcm;
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}