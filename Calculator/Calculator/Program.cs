using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        /// <summary>
        /// Main function foc calculator
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // todo: make interface for user to intreact with the methods with.
        }

        
        /// <summary>
        /// Adds two numbers together and returns the result.
        /// </summary>
        /// <param name="numA">the first number</param>
        /// <param name="numB">the second number</param>
        /// <returns>the two numbers combined</returns>
        static double Add(double numA, double numB)
        {
            // prepare a variable to hold the sum
            double sum;
            // add the two input numbers and save in the sum variable
            sum = numA + numB;
            // return sum to caller
            return sum;
        } 

        //todo: make method for subtraction

        //todo: make method for multiplicaiton

        //todo: make method for division

        // hack: Quick fix to be replaced later
        // todo: implement this, at some point

    }
}
