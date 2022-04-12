using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Run();
        }

        private void Run()
        {
            // 1. Initializing a DateTime object

            //// 1.1 Invoke constructors
            //// The following code creates a specific date using the DateTime
            //// constructor specifying the year, month, day, hour, minute, and second.
            //var date1 = new DateTime(1984, 11, 5, 8, 30, 52);
            //Console.WriteLine(date1); // 11/5/1984 8:30:52 AM
            //date1 = new DateTime(2022, 4, 11); 
            //Console.WriteLine(date1); // 4/11/2022 12:00:00 AM
            //date1 = new DateTime(2022, 12, 31, 15, 30, 52);
            //Console.WriteLine(date1); // 12/31/2022 3:30:52 PM
            //date1 = new DateTime();
            //Console.WriteLine(date1); // 1/1/0001 12:00:00 AM

            //// 1.2 Assigning a computed value
            //// You can assign the DateTime object a date and time value returned by a property or method.
            //// The following example assigns the current date and time, the current Coordinated Universal Time (UTC)
            //// date and time, and the current date to three new DateTime variables.
            //DateTime d1 = DateTime.Now; // 4/11/2022 9:04:37 AM
            //DateTime d2 = DateTime.UtcNow; // 4/11/2022 2:04:37 AM
            //DateTime d3 = DateTime.Today; // 4/11/2022 12:00:00 AM

            //// 1.3 Parsing a string that represents a DateTime
            //var dateString = "11/5/1984 8:30:52 AM";
            //DateTime date1 = DateTime.Parse(dateString, 
            //    System.Globalization.CultureInfo.InvariantCulture);
            //var iso8601String = "19841105T08:30:52Z";
            //DateTime date2 = DateTime.ParseExact(iso8601String, "yyyyMMddTHH:mm:ssZ",
            //    System.Globalization.CultureInfo.InvariantCulture);
            //Console.WriteLine(date2);
            // --------------------------------------------------------------------------------------------------------------------

            //// 2. DateTime Fields
            //// DateTime object contains teo static read-only fields called MaxValue and MinValue
            //// MinValue - It provides smallest possible value of DateTime
            //Console.WriteLine(DateTime.MinValue); // 1/1/0001 12:00:00 AM
            //// MaxValue - It provides largest possible value of DateTime
            //Console.WriteLine(DateTime.MaxValue); // 12/31/9999 11:59:59 PM
            //// --------------------------------------------------------------------------------------------------------------------
            ///

            // 3. DateTime Methods

            //// DateTime.Add(TimeSpan) Method: Returns a new DateTime that adds the value of 
            //// specified TimeSpan to the value of this instance.
            //// The following example calculates the day of the week that is 36 days (864 hours)
            //// from this moment
            //DateTime today = DateTime.Now; // 4/11/2022 10:18:38 AM
            //TimeSpan duration = new TimeSpan(36, 0, 0, 0);
            //DateTime answer = today.Add(duration);
            //Console.WriteLine("{0:dddd}", answer); // Tuesday

            // DateTime.AddDays(Double) Method:
            // Returns a new DateTime that adds the specified number of days to the value of this instance.
        }
    }
}
