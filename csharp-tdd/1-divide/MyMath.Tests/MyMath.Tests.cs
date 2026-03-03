using NUnit.Framework;
using System;
using System.IO;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Divide_MatrixByNumber_ReturnsDividedMatrix()
        {
            int[,] matrix = new int[,] { { 2, 4 }, { 6, 8 } };
            int[,] result = Matrix.Divide(matrix, 2);
            int[,] expected = new int[,] { { 1, 2 }, { 3, 4 } };
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_MatrixByZero_PrintsMessageAndReturnsNull()
        {
            int[,] matrix = new int[,] { { 2, 4 }, { 6, 8 } };
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                int[,] result = Matrix.Divide(matrix, 0);

                string expectedOutput = "Num cannot be 0" + Environment.NewLine;
                Assert.AreEqual(expectedOutput, sw.ToString());
                Assert.IsNull(result);
            }

            StreamWriter standardOutput = new StreamWriter(Console.OpenStandardOutput());
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 2);
            Assert.IsNull(result);
        }
    }
}
