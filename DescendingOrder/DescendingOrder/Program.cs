using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DescendingOrder(51232));
        }

        public static int DescendingOrder(int num)
        {
            var numString = num.ToString();
            var intList = numString.Select(x => Convert.ToInt32(x.ToString())).ToList();

            var numArray = intList.ToArray();
            Array.Sort(numArray);
            Array.Reverse(numArray);

            return int.Parse(numArray
            .Select(x => x.ToString())
            .Aggregate((prev, next) => prev + next));

        }
    }
}
