using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rot13CipherVersion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rot13("This is my first ROT13 excercise!"));
        }

        public static string Rot13(string message)
        {

            //string origAlphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //string ciphAlphabet = "nopqrstuvwxyzabcdefghijklmNOPQRSTUVWXYZABCDEFGHIJKLM";
            //string ciphedMsg = string.Empty;

            //for (int i = 0; i < message.Length; i++)
            //{
            //    ciphedMsg += origAlphabet.IndexOf(message.Substring(i, 1)) >= 0 ? ciphAlphabet.Substring(origAlphabet.IndexOf(message.Substring(i, 1)), 1) : message.Substring(i, 1);
            //};

            //return ciphedMsg;

            Dictionary<char, char> alphabet = new Dictionary<char, char>()
            {
                {'a', 'n'},{'b', 'o'},{'c', 'p'},{'d', 'q'},{'e', 'r'},{'f', 's'},{'g', 't'},{'h', 'u'},{'i', 'v'},{'j', 'w'},{'k', 'x'},{'l', 'y'},{'m', 'z'},{'n', 'a'},{'o', 'b'},{'p', 'c'},{'q', 'd'},{'r', 'e'},{'s', 'f'},{'t', 'g'},{'u', 'h'},{'v', 'i'},{'w', 'j'},{'x', 'k'},{'y', 'l'},{'z', 'm'}
            };

            var entryResult = "";
            var lowerCaseMessage = message.ToLower();
            for (int i = 0; i < message.Length; i++)
            {

                if (char.IsLetter(message[i]))
                    entryResult += (char.IsUpper(message[i])) ? alphabet[lowerCaseMessage[i]].ToString().ToUpper() : alphabet[lowerCaseMessage[i]].ToString();
                else
                    entryResult += message[i];
            }

            return entryResult;
        }
    }
}
