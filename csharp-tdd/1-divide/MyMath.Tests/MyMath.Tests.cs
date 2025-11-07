using System;
using System.IO;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Divide_RegularDivision_ReturnsCorrectResult()
        {
            int[,] matrix = { { 98, 0, -12 }, { 21, 972, 44 }, { -727, 60, -2 } };
            int[,] result = Matrix.Divide(matrix, 2);
            int[,] expected = { { 49, 0, -6 }, { 10, 486, 22 }, { -363, 30, -1 } };
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_NegativeDivisor_ReturnsCorrectResult()
        {
            int[,] matrix = { { 98, 0, -12 }, { 21, 972, 44 }, { -727, 60, -2 } };
            int[,] result = Matrix.Divide(matrix, -7);
            int[,] expected = { { -14, 0, 1 }, { -3, -138, -6 }, { 103, -8, 0 } };
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_DivideByZero_PrintsMessageAndReturnsNull()
        {
            int[,] matrix = { { 98, 0, -12 }, { 21, 972, 44 }, { -727, 60, -2 } };
            
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                int[,] result = Matrix.Divide(matrix, 0);
                
                Assert.IsNull(result);
                Assert.AreEqual("Num cannot be 0", sw.ToString().Trim());
            }
        }

        [Test]
        public void Divide_EmptyMatrix_ReturnsEmptyMatrix()
        {
            int[,] matrix = new int[0, 0];
            int[,] result = Matrix.Divide(matrix, 4);
            int[,] expected = new int[0, 0];
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 2);
            Assert.IsNull(result);
        }
    }
}