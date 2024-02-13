public class Solution {
    public bool solution(string s) {
        if (s.Length == 4 || s.Length == 6)
        {
            if (int.TryParse(s, out _))
                return true;
            else
                return false;
        }
        
        return false;
    }
}