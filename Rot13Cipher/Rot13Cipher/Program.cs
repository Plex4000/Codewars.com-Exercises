using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rot13Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rot13("Aa a"));
        }

        public static string Rot13(string message)
        {
            Dictionary<string, int> alphabet = new Dictionary<string, int>()
            {
                {"a", 1},{"b", 2},{"c", 3},{"d", 4},{"e", 5},{"f", 6},{"g", 7},{"h", 8},{"i", 9},{"j", 10},{"k", 11},{"l", 12},{"m", 13},{"n", 14},{"o", 15},{"p", 16},{"q", 17},{"r", 18},{"s", 19},{"t", 20},{"u", 21},{"v", 22},{"w", 23},{"x", 24},{"y", 25},{"z", 26}
            };

            var entryResult = "";
            for (int i = 0; i < message.Length; i++)
            {

                var temp = message[i].ToString().ToLower();

                if (char.IsLetter(message[i]))
                {
                    if (alphabet[temp] < 13)
                    {
                        var cipherLetter = from result in alphabet
                                           where result.Value == alphabet[temp] + 13
                                           select result.Key;
                        foreach (var key in cipherLetter)
                        {
                            string upperLetter;
                            if (char.IsUpper(message[i]))
                            {
                                upperLetter = key.ToString().ToUpper();
                                entryResult += upperLetter;
                            }
                            else
                            {
                                entryResult += key;
                            }

                        }

                    }
                    else if (alphabet[temp] > 13)
                    {
                        var targetValue = 13 - (26 - alphabet[temp]);

                        var cipherLetter = from result in alphabet
                                           where result.Value == targetValue
                                           select result.Key;

                        foreach (var key in cipherLetter)
                        {
                            string upperLetter;
                            if (char.IsUpper(message[i]))
                            {
                                upperLetter = key.ToString().ToUpper();
                                entryResult += upperLetter;
                            }
                            else
                            {
                                entryResult += key;
                            }
                        }
                    }
                    else if (alphabet[temp] == 13)
                    {
                        if (char.IsUpper(message[i]))
                        {
                            entryResult += "Z";
                        }
                        else
                        {
                            entryResult += "z";
                        }
                    }
                }
                else
                {
                    entryResult += message[i];
                }
                
            }
            return entryResult;

        }
    }
}
