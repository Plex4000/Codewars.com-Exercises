using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ReverseInt(560));
            Console.WriteLine(palindromeChainLength(87));
            //int n = 123405;
            //int left = n;
            //int rev = 0;
            //while (left > 0)
            //{
            //    var r = left % 10;
            //    rev = rev * 10 + r;
            //    left = left / 10;  //left = Math.floor(left / 10); 
            //}

            //Console.WriteLine(rev);
        }

        public static int palindromeChainLength(int Number)
        {
            var temp1 = ReverseInt(Number);
            var temp2 = Number.ToString();
            var steps = 0;
            if (temp1 == temp2)
                return 0;
            else
            {
                while (temp1 != temp2)
                {
                    steps++;
                    var temp3 = long.Parse(temp1) + long.Parse(temp2);

                    if (ReverseInt(temp3) == temp3.ToString())
                    {
                        return steps;
                    }
                    else
                    {
                        temp1 = temp3.ToString();
                        temp2 = ReverseInt(temp3);
                    }
                }
                return 0;
            }
           
        }

        public static string ReverseInt(long Number)
        {
            var stringNum = Number.ToString();
            var numberReversed = "";
            for (int i = stringNum.Length - 1; i >= 0; i--)
            {
                numberReversed += stringNum[i];
            }
            return numberReversed;
        }
    }
}
