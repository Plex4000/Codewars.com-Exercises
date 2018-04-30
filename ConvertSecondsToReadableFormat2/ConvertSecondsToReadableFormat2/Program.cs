using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSecondsToReadableFormat2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(formatDuration(132030240));
        }

        public static string formatDuration(int seconds)
        {
            var readableSeconds = seconds;
            //get num of years
            var years = 0;
            while (readableSeconds >= 31536000)
            {
                readableSeconds -= 31536000;
                years++;
            }

            //get num of years
            var days = 0;
            while (readableSeconds >= 86400)
            {
                readableSeconds -= 86400;
                days++;
            }

            //get num of hours
            var hours = 0;
            while (readableSeconds >= 3600)
            {
                readableSeconds -= 3600;
                hours++;
            }

            //get num of minutes
            var minutes = 0;
            while (readableSeconds >= 60)
            {
                readableSeconds -= 60;
                minutes++;
            }

            Console.WriteLine(readableSeconds);

            var readableTime = "";

            if (seconds == 0)
            {
                readableTime = "now";
            }
            else if (seconds == 1)
            {
                readableTime = "1 second";
            }
            else
            {
                if (years > 1)
                {
                    readableTime += years + " years,";
                }
                else if (years == 1)
                {
                    readableTime += years + " year,";
                }

                if (days > 1 && years > 0)
                {
                    readableTime += " " + days + " days,";
                }
                else if (days == 1 && years > 0)
                {
                    readableTime += " " + days + " day,";
                }
                else if (days > 1)
                {
                    readableTime += days + " days,";
                }
                else if (days == 1)
                {
                    readableTime += days + " day,";
                }

                if (hours >= 1 && readableSeconds == 0)
                {
                    readableTime += " " + hours + " hours and";
                }
                else if (hours > 1 && (days > 0 || years > 0))
                {
                    readableTime += " " + hours + " hours,";
                }
                else if (hours == 1 && (days > 0 || years > 0))
                {
                    readableTime += " " + hours + " hour,";
                }
                else if (hours > 1)
                {
                    readableTime += hours + " hours,";
                }
                else if (hours == 1)
                {
                    readableTime += hours + " hour,";
                }

                if (minutes > 1 && hours > 0)
                {
                    readableTime += " " + minutes + " minutes";
                }
                else if (minutes == 1 && hours > 0)
                {
                    readableTime += " " + minutes + " minute";
                }
                else if (minutes > 1)
                {
                    readableTime += minutes + " minutes";
                }
                else if (minutes == 1)
                {
                    readableTime += minutes + " minute";
                }

                if (readableSeconds > 1 && (minutes > 0 || hours > 0))
                {
                    readableTime += " and " + readableSeconds + " seconds";
                }
                else if (readableSeconds == 1 && (minutes > 0 || hours > 0))
                {
                    readableTime += " and " + readableSeconds + " second";
                }
                else if (readableSeconds == 1)
                {
                    readableTime += seconds + " second";
                }
            }

            return readableTime;
        }
    }
}
