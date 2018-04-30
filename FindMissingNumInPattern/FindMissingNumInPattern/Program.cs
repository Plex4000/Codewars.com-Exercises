using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingNumInPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMissing(new List<int> { 11, 9, 5, 3, 1 }));
        }


        public static int FindMissing(List<int> list)
        {
            var ascendingGapVal = 0;
            var descendingGapVal = 0;
            var listType = "";
            for (int i = 0; i < list.Count(); i++)
            {
                if(i == 0)
                {
                    if(list[i + 1] > list[i])
                    {
                        var tempVal = (list[i + 2] - list[i + 1]) - (list[i + 1] - list[i]);
                        if(tempVal == 0)
                        {
                            ascendingGapVal = list[i + 1] - list[i];
                        }
                        else
                        {
                            ascendingGapVal = (list[i + 2] - list[i + 1]) -(list[i + 1] - list[i]);
                        }

                        listType = "ascending";

                    }
                    else
                    {
                        var tempVal = (list[i] - list[i + 1]) - (list[i + 1] - list[i + 2]);
                        if (tempVal == 0)
                        {
                            descendingGapVal = list[i] - list[i + 1];
                        }
                        else
                        {
                            descendingGapVal = (list[i] - list[i + 1]) - (list[i + 1] - list[i + 2]);
                            if(descendingGapVal < 0)
                            {
                                descendingGapVal *= -1;
                            }
                        }

                    }

                }

                if (i != list.Count() - 1 && i != 0)
                {
                    if(listType == "ascending")
                    {
                        if (list[i + 1] - list[i] != ascendingGapVal)
                        {
                            return (list[i] + ascendingGapVal);
                        }
                    }
                    else
                    {
                        if (list[i] - list[i + 1] != descendingGapVal)
                        {
                            return (list[i] - descendingGapVal);
                        }
                    }
                   
                }
            }
            return 0;
        }
    }
}
