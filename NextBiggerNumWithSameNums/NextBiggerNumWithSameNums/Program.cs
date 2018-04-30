using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBiggerNumWithSameNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NextBiggerNumber(12545579));

        }

        public static int GetComboFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetComboFactorial(number - 1);
        }

        public static long NextBiggerNumber(long num)
        {
            var stringNum = num.ToString();
            var numOfComboPossible = GetComboFactorial(stringNum.Length);

            List<string> combinedList = new List<string>();


            var numString = num.ToString();
            var intList = numString.Select(x => Convert.ToInt32(x.ToString())).ToList();

            Random rand = new Random();
            int randomIndex;
            string randomIndexCombo = "";
            List<string> indexCombos = new List<string>();

            while (numOfComboPossible > 0)
            {
                string tempStringNum = "";
                List<int> indexList = new List<int>();

                for (int i = 0; i < intList.Count; i++)
                {
                    randomIndex = rand.Next(0, intList.Count);

                    while (indexList.Contains(randomIndex))
                    {
                        randomIndex = rand.Next(0, intList.Count);
                    }

                    tempStringNum += intList[randomIndex];
                    indexList.Add(randomIndex);
                    randomIndexCombo += randomIndex;

                }

                if (!indexCombos.Contains(randomIndexCombo))
                {
                    combinedList.Add(tempStringNum);
                    tempStringNum = "";
                    numOfComboPossible--;
                }
                else
                {
                    tempStringNum = "";
                }

            }

            //convert string array to long datatype array
            long[] finalArray = Array.ConvertAll(combinedList.ToArray(), long.Parse);

            //sort array in ascending order
            Array.Sort(finalArray);

            long nextHigherNum = -1;

            foreach (long number in finalArray)
            {
                if (number > num)
                {
                    nextHigherNum = number;
                    break;
                }
                   
                
            }

            return nextHigherNum;

        }
    }
}
