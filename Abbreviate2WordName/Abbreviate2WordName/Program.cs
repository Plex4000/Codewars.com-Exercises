using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbreviate2WordName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AbbrevName("John Doe"));
        }

        public static string AbbrevName(string name)
        {
            var splitName = name.Split(' ');
            char[] initials = new char[2];

            for (int i = 0; i < 2; i++)
            {
                initials[i] = char.IsLower(splitName[i][0]) ? char.ToUpper(splitName[i][0]) : splitName[i][0];
            }

            return string.Join(".", initials);
        }
    }
}
