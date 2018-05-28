using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexValidateATMPIN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePin("123335"));
        }

        public static bool ValidatePin(string pin)
        {
            return new Regex(@"^(\d{4}|\d{6})$").IsMatch(pin);

        }
    }
}
