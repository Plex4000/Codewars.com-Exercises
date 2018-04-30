using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            GetVowelCount("The quick brown fox jumped over the chicken!");
        }
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }

    }
}
