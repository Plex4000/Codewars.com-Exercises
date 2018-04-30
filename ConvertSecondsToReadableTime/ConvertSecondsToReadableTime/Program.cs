using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSecondsToReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetReadableTime(60));
        }

        public static string GetReadableTime(int seconds)
        {
            var hours = 0;
            while (seconds >= 3600)
            {
                seconds -= 3600;
                hours++;
               
            }

            var minutes = 0;
            while (seconds >= 60)
            {
                seconds -= 60;
                minutes++;
            }

            var hoursString = "";
            if (hours < 10)
            {
                hoursString = "0" + hours.ToString();
            }
            else
            {
                hoursString = hours.ToString();
            }

            var minutesString = "";
            if (minutes < 10)
            {
                minutesString = "0" + minutes.ToString();
            }
            else
            {
                minutesString = minutes.ToString();
            }

            var secondsString = "";
            if(seconds < 10)
            {
                secondsString = "0" + seconds.ToString();
            }
            else
            {
                secondsString = seconds.ToString();
            }


            if(hours == 0)
                hoursString = "00";
            if(minutes == 0)
                minutesString = "00";
          
              
            return $"{hoursString}:{minutesString}:{secondsString}";


        }
    }
}
