using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PigIt("My friend is here !"));
        }
        public static string PigIt(string str)
        {
            var splitSentense = str.Split(' ');
            List<string> originalSentense = new List<string>(splitSentense);
            List<string> modifiedSentense = new List<string>();
            foreach (var word in splitSentense)
            {
                if (Char.IsLetter(word[0]))
                {
                    var letters = new List<char>(word);
                    letters.Add(word[0]);
                    letters.RemoveAt(0);
                    letters.Add('a');
                    letters.Add('y');
                    var wordString = letters.ToArray();
                    modifiedSentense.Add(new string(wordString));
                }
                else
                {
                    modifiedSentense.Add(word);
                }
               
            }
           
            return string.Join(" ", modifiedSentense);
        }
    }
}
