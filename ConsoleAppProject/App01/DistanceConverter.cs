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
        private double miles;
        private double feet;

        /// <summary>
        /// The purpose of this method is to call the other methods
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
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
        /// 
        /// </summary>
        /// 
        private void CalculateFeet()
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// 
        private void OutputFeet()
        {

        }
    }
}
