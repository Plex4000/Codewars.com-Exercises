using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsIsogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsIsogram("Barium"));
        }

        public static bool IsIsogram(string str)
        {
            var val = str.ToLower();

            for (int i = 0; i < val.Length; i++)
            {
                for (int j = 0; j < val.Length; j++)
                {
                    if(j != i)
                    {
                        if(val[i] == val[j])
                        {
                            return false;
                        }
                    }
                    
                }
            }
            return true;
        }
    }
}
