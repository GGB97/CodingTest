using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            min = min < arr[i] ? min : arr[i];
        }

        List<int> list = new List<int>(arr);
        list.Remove(min);

        if (list.Count < 1)
            return new int[] { -1 };

        return list.ToArray();
    }
}