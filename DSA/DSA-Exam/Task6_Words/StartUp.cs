// 100/100
namespace Search
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            //Generate prefix and sufix
            var prefixList = new List<string>();
            var sufixList = new List<string>();

            string prefix = string.Empty;
            string sufix = string.Empty;

            for (int i = 0; i < firstString.Length; i++)
            {
                prefix = prefix + firstString[i];
                prefixList.Add(prefix);

                for (int j = i + 1; j < firstString.Length; j++)
                {
                    sufix = sufix + firstString[j];
                }

                sufixList.Add(sufix);
                sufix = string.Empty;
            }

            // generate combinations
            long result = 0;

            for (int i = 0; i < prefixList.Count; i++)
            {
                string pref = prefixList[i];
                string second = sufixList[i];

                long firstComb = 1;
                long secondComb = 1;

                if (pref != "")
                {
                    firstComb = DoMagic(pref, secondString);
                }
                if (second != "")
                {
                    secondComb = DoMagic(second, secondString);
                }

                result += firstComb * secondComb;
            }

            Console.WriteLine(result);
        }


        // copy from here https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/blob/master/14.%20Strings-and-String-Algorithms/demos/Kmp.cs
        public static long DoMagic(string firstString, string secondString)
        {
            int n = secondString.Length;
            int m = firstString.Length;
            long sum = 0;
            // precompute

            int[] fl = new int[m + 1];
            fl[0] = -1;

            for (int i = 1; i < m; i++)
            {
                int j = fl[i];
                while (j >= 0 && firstString[j] != firstString[i])
                {
                    j = fl[j];
                }
                fl[i + 1] = j + 1;
            }

            // search

            int matched = 0;
            for (int i = 0; i < n; i++)
            {
                while (matched >= 0 && secondString[i] != firstString[matched])
                {
                    matched = fl[matched];
                }

                matched++;

                if (matched == m)
                {
                    sum++;
                    matched = fl[matched];
                }
            }

            return sum;
        }
    }
}