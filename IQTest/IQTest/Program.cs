using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("70 1 20 30 40"));
        }
        public static int Test(string numbers)
        {
            int[] array = numbers.Split(' ').Select(int.Parse).ToArray();
            int evenCount = 0;
            int oddCount = 0;
            int evenIndex = 0;
            int oddIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenCount++;
                    evenIndex = i;
                }
                else
                {
                    oddCount++;
                    oddIndex = i;
                }
            }

            if (evenCount == 1)
                return evenIndex + 1;
            else
                return oddIndex + 1;
        }
    }
}
