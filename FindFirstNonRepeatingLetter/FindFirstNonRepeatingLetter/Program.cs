using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFirstNonRepeatingLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstNonRepeatingLetter("sTreSS"));
        }

        public static string FirstNonRepeatingLetter(string s)
        {

            var counts = s.GroupBy(c => c.ToString(), c => c, StringComparer.OrdinalIgnoreCase) // put each character into a "bucket"
                                           // then convert to dictionary where key = character, value = count
                     .ToDictionary(grp => grp.Key, grp => grp.Count());

            string nonRepeatingLetter;
            foreach (var keyValuePair in counts)
            {
               
                if (keyValuePair.Value == 1)
                {
                    nonRepeatingLetter = keyValuePair.Key;
                    return nonRepeatingLetter;
                }
            }

            return "";

           

            //char nonRepeatingLetter = ' ';
            //for (int i = 0; i < s.Length; i++)
            //{
            //    for (int j = 1; j < s.Length; j++)
            //    {
            //        if (s[i] != s[j])
            //        {
            //            nonRepeatingLetter = s[i];
            //        }
            //        else if (s[i] == s[j])
            //        {
            //            nonRepeatingLetter = ' ';
            //            break;
            //        }
            //    }

            //    if (nonRepeatingLetter != ' ')
            //        break;

            //}
            //return nonRepeatingLetter.ToString();
        }
    }
    
}
