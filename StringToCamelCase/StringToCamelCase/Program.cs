using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToCamelCase("the-Stealth-Warrior_Homer"));
        }

        public static string ToCamelCase(string str)
        {
            var phrase = str.Split('-', '_');
            var camelCasePhrase = phrase[0];

            for (int i = 1; i < phrase.Length; i++)
            {
                camelCasePhrase += char.ToUpper(phrase[i][0]) + phrase[i].Substring(1);
            }

            return camelCasePhrase;
        }
    }
}
