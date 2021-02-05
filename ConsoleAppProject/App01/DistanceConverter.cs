using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class offers methods for converting a given
    /// distance meausred in miles to the equivalent
    /// distance measured in feet
    /// </summary>
    /// <author>
    /// Leo Juster version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet;


        /// <summary>
        /// The purpose of this method is to call the other methods
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n     Convert Miles to Feet    ");
            Console.WriteLine("\n        By Leo Juster         ");
            Console.WriteLine("\n------------------------------");
        }

        /// <summary>
        /// Prompts the user to enter the miles.
        /// Input miles as double number
        /// </summary>
        /// 
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// This is the method that converts the miles into feet
        /// </summary>
        /// 
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        /// <summary>
        /// This method is responsible for the output of the results
        /// after it has been calculated.
        /// It will print out the results at the end
        /// </summary>
        ///

        private void OutputFeet()
        {
            Console.WriteLine(miles + " Mile is " + feet + " feet!");
        }
    }
}
