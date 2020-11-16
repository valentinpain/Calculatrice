using System;
using System.Collections.Generic;
using System.Text;

namespace Calculatrice
{
    /// <summary>
    /// Performs classic calculator operations on numbers given by the user
    /// </summary>
    public static class Calculatrice
    {
        /// <summary>
        /// Adds two numbers
        /// </summary>
        /// <param name="firstNumber">One of the numbers that the user wants to add</param>
        /// <param name="secondNumber">The second number of the addition</param>
        /// <returns>The result of the addition</returns>
        public static double addition(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        /// <summary>
        /// Substracts two numbers (the order is important here)
        /// </summary>
        /// <param name="firstNumber">One of the numbers that the user wants to substracts</param>
        /// <param name="secondNumber">The second number of the substraction</param>
        /// <returns>The result of the substraction</returns>
        public static double substraction(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
