using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");
            string currentDay = Console.ReadLine();
            bool correct = false;

            try
            {
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), currentDay);
                correct = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Pleas enter an actual day of the week.");
            }

            if (correct == true)
            {
                Console.WriteLine("You are correct!");
            }
            Console.ReadLine();
        }
    }

    public enum DaysOfTheWeek
    {
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday
    }
}
