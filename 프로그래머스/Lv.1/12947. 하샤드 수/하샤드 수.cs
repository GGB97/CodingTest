public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int sum = 0; int n = x;
        while(n != 0)
        {
            sum += n % 10;
            n =n/10;
        }
        
        if(x % sum == 0)
        {
            return answer = true;
        }
        else
        {
            return answer = false;
        }
    }
}