using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class allows the user to convert distnaces
    /// between Miles, Feet and Metres
    /// They are also allowed to choose their own combinations.
    /// </summary>
    /// <author>
    /// Leo Juster version 0.1
    /// </author>
    public class DistanceConverter
    {
        /// <summary>
        /// Conversions constants
        /// </summary>
        /// 
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;

        /// <summary>
        /// distance variables
        /// </summary>
        /// 
        private double miles;
        private double feet;
        private double metres;


        /// <summary>
        /// The purpose of this method is to call the other methods
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");

            miles = InputDistance("Please enter the number of miles >");

            CalculateFeet();

            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            feet = InputDistance("Please enter the number of feet >");

            CalculateMiles();

            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }
        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");

            miles = InputDistance("Please enter the number of miles >");
            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }

        /// <summary>
        /// Prompts the user to enter the miles.
        /// Input miles as double number
        /// </summary>
        ///

        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// This is the method that converts the miles into feet
        /// </summary>
        /// 
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        private void CalculateMiles()
        {
            feet = miles / FEET_IN_MILES;
        }

        private void CalculateMetres()
        {
            feet = miles * METRES_IN_MILES;
        }

        /// <summary>
        /// This method is responsible for the output of the results
        /// after it has been calculated.
        /// It will print out the results at the end
        /// </summary>
        ///

        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit}" +
                $" is {toDistance} {toUnit}!");
        }

        /// <summary>
        /// This is a short descriptoon of the programme and the author of it
        /// </summary>
        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n      DISTANCE CONVERTER      ");
            Console.WriteLine("\n        By Leo Juster         ");
            Console.WriteLine("\n------------------------------");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }

    }
}
