using System;

namespace TestProject
{
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;
    using System.Text;
    using System;

    class Solution
    {
        static int[] oneToNineteen = {0,"one".Length,"two".Length,"three".Length,"four".Length,"five".Length,"six".Length,"seven".Length,"eight".Length,"nine".Length,"ten".Length,
            "eleven".Length,"twelve".Length,"thirteen".Length,"fourteen".Length,"fifteen".Length,"sixteen".Length,"seventeen".Length,"eighteen".Length,"nineteen".Length};
        static int[] tenth = {0,0,"twenty".Length,"thirty".Length,"forty".Length,"fifty".Length,"sixty".Length,"seventy".Length,"eighty".Length,"ninety".Length };

        public static int BelowOneHundred(int n)
        {

            if (n < 20)
                return oneToNineteen[n];

            return tenth[n / 10 ] + oneToNineteen[n % 10];
        }

        public static int NumberLength(int n)
        {
            if (n < 100)
                return BelowOneHundred(n);

            int res = 0;
            int h = n / 100 % 10;
            int t = n / 1000;
            int s = n % 100;
            if (n > 999)
                res += BelowOneHundred(t) + "thousand".Length;
            if (h != 0)
                res += oneToNineteen[h] + "hundred".Length;
            if (s != 0)
                res += "and".Length + BelowOneHundred(s);
            return res;
        }

        public static int CalculateNumberLength(int n) {
            int num = 0;
            for (int i = n; i>0; i--)
            {
                num += NumberLength(i);
            }
            return num;
        }

        public static void Main(string[] args)
        {
            int result = CalculateNumberLength(1000);    
            Console.WriteLine(result);
       
        }

        }
}


