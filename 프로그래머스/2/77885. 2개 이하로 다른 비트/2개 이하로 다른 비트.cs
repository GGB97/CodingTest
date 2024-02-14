    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        public long[] solution(long[] numbers)
        {
            var answerList = new List<long>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) // 짝수라면
                    answerList.Add(numbers[i] + 1);
                else // 홀수라면
                    answerList.Add(Function(numbers[i]));
            }

            return answerList.ToArray();
        }

        // 홀수일 경우 조건에 부합하는 숫자를 찾아 리턴
        public long Function(long num)
        {
            var sb = new StringBuilder();

            // 2진수 변환
            while (num != 0)
            {
                sb.Insert(0, (num % 2).ToString());
                num /= 2;
            }
            sb.Insert(0, "0"); // 맨 앞에 0 추가 (전부 다 1일경우 예외처리)

            // 홀수이므로 오른쪽 맨 끝은 무조건 1이 됨 
            for (int i = sb.Length - 2; i >= 0; i--)
            {
                // 처음 0 자리를 1로 바꿈
                if (sb[i] == '0')
                {
                    // 마치 쉬프트 연산하듯 01 -> 10으로 바꿈
                    sb[i] = '1';
                    sb[i + 1] = '0';
                    break;
                }
            }

            // 10진수 변환
            return Convert.ToInt64(sb.ToString(), 2);
        }
    }