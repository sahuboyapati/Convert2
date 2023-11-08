using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCovert2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convert a string to an integer using TryParse
            Console.WriteLine("Enter a string to convert to an integer:");
            string inputString = Console.ReadLine();
            if (int.TryParse(inputString, out int intValue))
            {
                // Conversion successful, multiply by 5
                int resultValue = intValue * 5;
                Console.WriteLine("Conversion to integer successful. Result: " + resultValue);
            }
            else
            {
                // Conversion failed
                Console.WriteLine("Conversion to integer failed. Invalid input.");
            }

            // Convert a string to a DateTime object using Convert
            Console.WriteLine("\nEnter a date string to convert to a DateTime object (e.g., '2023/11/08'):");
            string dateString = Console.ReadLine();
            try
            {
                DateTime dateValue = Convert.ToDateTime(dateString);
                // Subtract 1 month from the obtained DateTime
                DateTime newDateValue = dateValue.AddMonths(-1);
                Console.WriteLine("Conversion to DateTime successful. Result: " + newDateValue.ToString("yyyy/MM/dd"));
            }
            catch (FormatException)
            {
                // Conversion failed due to an invalid format
                Console.WriteLine("Conversion to DateTime failed. Invalid date format.");
            }
            catch (Exception e)
            {
                // Other exceptions
                Console.WriteLine("An error occurred: " + e.Message);
            }

            // Convert a string to a TimeSpan object using Parse
            Console.WriteLine("\nEnter a time string to convert to a TimeSpan object (e.g., '02:30:00'):");
            string timeString = Console.ReadLine();
            try
            {
                TimeSpan timeValue = TimeSpan.Parse(timeString);
                // Add 2 hours to the obtained TimeSpan
                TimeSpan newTimeValue = timeValue.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine("Conversion to TimeSpan successful. Result: " + newTimeValue);
            }
            catch (FormatException)
            {
                // Conversion failed due to an invalid format
                Console.WriteLine("Conversion to TimeSpan failed. Invalid time format.");
            }
            catch (Exception e)
            {
                // Other exceptions
                Console.WriteLine("An error occurred: " + e.Message);
                Console.ReadKey();
            }
        }
    }
}



