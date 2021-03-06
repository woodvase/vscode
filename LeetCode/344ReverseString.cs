namespace LeetCode
{
    using System;
    using System.Collections.Generic;

    public partial class Solution
    {
        public string ReverseString(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return s;
            }

            int i = 0;
            char[] a = new char[s.Length];
            while (i < s.Length)
            {
                a[i] = s[s.Length - i - 1];
                i++;
            }

            return new string(a);
        }

        public IList<string> FizzBuzz(int n)
        {
            List<string> ret = new List<string>();
            if (n <= 0)
            {
                return ret;
            }

            int i = 1;
            while (i <= n)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    ret.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    ret.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    ret.Add("Buzz");
                }
                else
                {
                    ret.Add(i.ToString());
                }
                i++;
            }

            return ret;
        }

        public uint reverseBits(uint n)
        {
            Queue<uint> q = new Queue<uint>();
            while (n != 0)
            {
                q.Enqueue(n % 2);
                n = n / 2;
            }

            int m = q.Count;
            uint r = 0;
            while (q.Count > 0)
            {
                r = r * 2 + q.Dequeue();
            }

            m = 32 - m;
            int i = 0;
            while (i < m)
            {
                r = r << 1;
                i++;
            }

            return r;
        }
    }
}