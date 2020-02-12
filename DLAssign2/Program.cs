// Created By: David Lutz
// Date Created: February 12, 2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLAssign2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int option;

            // Loop until the user exits the application
            do
            {
                // Menu
                do
                {
                    // Reset option variable
                    option = 0;
                    // Display the options
                    Console.WriteLine("Please enter an option");
                    Console.WriteLine("1. Enter Triangle Dimensions");
                    Console.WriteLine("2. Exit");
                    try
                    {
                        // Get the option from the user
                        option = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        // Clear the screen and display an error
                        Console.Clear();
                        Console.WriteLine("Error, invalid input, please try again");
                    }
                } while (option == 0);

                // Execute the chosen option
                switch (option)
                {
                    // Enter triangle dimensions
                    case 1:
                        // Clear the console
                        Console.Clear();
                        // Get the sides of the triangle
                        Console.WriteLine("Enter the length of the first side:");
                        int len1 = GetLength();
                        Console.Clear();
                        Console.WriteLine("Enter the length of the second side:");
                        int len2 = GetLength();
                        Console.Clear();
                        Console.WriteLine("Enter the length of the third side:");
                        int len3 = GetLength();
                        Console.Clear();
                        // Analyze the lengths and display the results
                        Console.WriteLine(TriangleSolver.Analyze(len1, len2, len3));
                        break;
                    // Exit the application
                    case 2:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                } 
            } while (option != 2);
        }
        /// <summary>
        /// Gets the length of a side of the triangle from the user
        /// </summary>
        /// <returns>The length from te user</returns>
        private static int GetLength()
        {
            // Variables
            int len = 0;

            // Get a valid positive integer from the user
            do
            {
                try
                {
                    // Get the length from the user
                    len = int.Parse(Console.ReadLine());
                    // Display an error if the input is a valid integer but 0 or less
                    if (len <= 0)
                    {
                        // Display the error
                        Console.WriteLine("Error, input must be a positive integer greater than 0, please try again");
                        // Set the length to 0
                        len = 0;
                    }
                }
                catch (Exception)
                {
                    // Display the error
                    Console.WriteLine("Error, invalid input, please try again");
                }
            } while (len == 0);

            // Return the length
            return len;
        }
    }
}
