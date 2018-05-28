using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumStringsAsNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumStrings("123", "456"));
        }

        public static string sumStrings(string a, string b)
        {
            BigInteger numOne;
            BigInteger numTwo;
            BigInteger.TryParse(a, out numOne);
            BigInteger.TryParse(b, out numTwo);
            return (numOne + numTwo).ToString();
        }
    }
}
