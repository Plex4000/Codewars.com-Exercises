using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSmallestNumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindSmallestInt(new int[] { 78, 56, -2, 12, 8, -33 }));
        }

        public static int FindSmallestInt(int[] args)
        {
            Array.Sort(args);
            return args[0];
        }
    }
}
