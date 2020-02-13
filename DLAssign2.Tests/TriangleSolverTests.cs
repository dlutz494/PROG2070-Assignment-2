using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DLAssign2;


namespace DLAssign2.Tests
{
    [TestFixture]
    public class TriangleSolverTests
    {
        [Test]
        // These inputs were selected to test that having the sum of 2 inputs
        // be equal to the third would give an invalid triangle
        public void Analyze_Given1And2And3_ResultIsInvalid()
        {
            // Arrange
            int len1 = 1;
            int len2 = 2;
            int len3 = 3;
            string output = "";

            // Act
            output = TriangleSolver.Analyze(len1, len2, len3);

            // Assert
            Assert.AreEqual($"The Triangle ({len1}, {len2}, {len3}) is Invalid", output);
        }

        [Test]
        // These inputs were used to test an equilateral triangle
        // using the smallest allowed integers
        public void Analyze_Given1And1And1_ResultIsEquilateral()
        {
            // Arrange
            int len1 = 1;
            int len2 = 1;
            int len3 = 1;
            string output = "";

            // Act
            output = TriangleSolver.Analyze(len1, len2, len3);

            // Assert
            Assert.AreEqual($"The Triangle ({len1}, {len2}, {len3}) is Equilateral", output);
        }

        [Test]
        // These inputs were used to test a simple isosceles triangle
        public void Analyze_Given4And4And5_ResultIsIsosceles()
        {
            // Arrange
            int len1 = 4;
            int len2 = 4;
            int len3 = 5;
            string output = "";

            // Act
            output = TriangleSolver.Analyze(len1, len2, len3);

            // Assert
            Assert.AreEqual($"The Triangle ({len1}, {len2}, {len3}) is Isosceles", output);
        }

        [Test]
        // These inputs were used to test a simple scalene triangle
        public void Analyze_Given4And5And6_ResultIsScalene()
        {
            // Arrange
            int len1 = 4;
            int len2 = 5;
            int len3 = 6;
            string output = "";

            // Act
            output = TriangleSolver.Analyze(len1, len2, len3);

            // Assert
            Assert.AreEqual($"The Triangle ({len1}, {len2}, {len3}) is Scalene", output);
        }

        [Test]
        // These inputs were used to test the sum of 2 lengths being
        // less than the third length, giving an invalid triangle
        public void Analyze_Given1And1And4_ResultIsInvalid()
        {
            // Arrange
            int len1 = 1;
            int len2 = 1;
            int len3 = 4;
            string output = "";

            // Act
            output = TriangleSolver.Analyze(len1, len2, len3);

            // Assert
            Assert.AreEqual($"The Triangle ({len1}, {len2}, {len3}) is Invalid", output);
        }

        [Test]
        // These inputs were used to test much larger numbers
        // The output would be invalid as the sum of the first 2 lengths 
        // are much less than the third length
        public void Analyze_Given1111And1111And3000_ResultIsInvalid()
        {
            // Arrange
            int len1 = 1111;
            int len2 = 1111;
            int len3 = 3000;
            string output = "";

            // Act
            output = TriangleSolver.Analyze(len1, len2, len3);

            // Assert
            Assert.AreEqual($"The Triangle ({len1}, {len2}, {len3}) is Invalid", output);
        }
    }
}
