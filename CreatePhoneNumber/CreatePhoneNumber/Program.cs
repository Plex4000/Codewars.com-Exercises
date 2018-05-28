using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            var phoneNum = "(";
            for (int i = 0; i < numbers.Length; i++)
            {
                phoneNum += numbers[i];

                if (i == 2)
                    phoneNum += ") ";
               
                if(i == 5)
                    phoneNum += "-";
                
            }
            return phoneNum;
        }
    }
}
