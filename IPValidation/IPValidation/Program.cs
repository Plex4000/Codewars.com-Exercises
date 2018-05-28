using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(is_valid_IP(""));
        }

        public static bool is_valid_IP(string IpAddres)
        {
            var ipAddressArray = IpAddres.Split('.');

            if(ipAddressArray.Length < 4)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < ipAddressArray.Length; i++)
                {

                    int result;
                    bool isNum = int.TryParse(ipAddressArray[i], out result);
                    if (ipAddressArray[i][0] == '0' || !isNum || result > 255 || result < 0 || ipAddressArray[i].Contains(' '))
                    {
                        return false;
                    }
                }
            }

           
            return true;
        }
    }
}
