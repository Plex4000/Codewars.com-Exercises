using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitString
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution("Streets");
        }

        public static string[] Solution(string str)
        {
            var twoLetterList = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {

                if (i % 2 == 0 && i == (str.Length - 1))
                {
                    twoLetterList.Add(str[i] + "_");
                    break;
                }
                else
                {
                    twoLetterList.Add(str.Substring(i, 2));
                    i++;
                }
            }
           return twoLetterList.ToArray();
         
        }
    }
}
