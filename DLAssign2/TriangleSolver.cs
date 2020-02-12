// Created By: David Lutz
// Date Created: February 12, 2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLAssign2
{
    public static class TriangleSolver
    {
        /// <summary>
        /// Analyze three length variables and return a string indicating if they create a valid triangle
        /// </summary>
        /// <param name="len1">Length of first side</param>
        /// <param name="len2">Length of second side</param>
        /// <param name="len3">Length of third side</param>
        /// <returns>String containing the length variables and the triangle created by them, if valid</returns>
        public static string Analyze(int len1, int len2, int len3)
        {
            // Determine if the triangle is valid
            if (LengthCheck(len1, len2, len3) && LengthCheck(len1, len3, len2) && LengthCheck(len2, len3, len1))
            {
                // Determine the type of triangle
                // Equilateral
                if (len1 == len2 && len2 == len3)
                {
                    // Return the output
                    return $"The Triangle ({len1}, {len2}, {len3}) is Equilateral";
                }
                // Isosceles
                else if (len1 == len2 || len1 == len3 || len2 == len3)
                {
                    // Return the output
                    return $"The Triangle ({len1}, {len2}, {len3}) is Isosceles";
                }
                // Scalene
                else
                {
                    // Return the output
                    return $"The Triangle ({len1}, {len2}, {len3}) is Scalene";
                }
            }
            else
            {
                // Invalid triangle
                return $"The Triangle ({len1}, {len2}, {len3}) is Invalid";
            }
        }

        /// <summary>
        /// Checks that the sum of two given lengths is greater than the third
        /// </summary>
        /// <param name="len1">First length</param>
        /// <param name="len2">Second length</param>
        /// <param name="len3">Third length</param>
        /// <returns>True if the sum of the first two lengths is greater than the third length, false otherwise</returns>
        public static bool LengthCheck(int len1, int len2, int len3)
        {
            // Return true if the sum of len1 and len2 is greater than len3
            if (len1 + len2 > len3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
