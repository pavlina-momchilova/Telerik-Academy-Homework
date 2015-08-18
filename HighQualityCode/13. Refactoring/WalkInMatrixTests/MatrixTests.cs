namespace WalkInMatrixTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RotatingWalkInMatrix;
    using System.Text;

    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MethodShouldThrowErrorWhenEnteredSizeIsLessThanOne()
        {
            Matrix matrix = new Matrix(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MethodShouldThrowErrorWhenEnteredSizeIsMoreThanOneHundred()
        {
            Matrix matrix = new Matrix(101);
        }

        [TestMethod]
        public void ShouldWorkProperlyWhenRightSizeIsEnter()
        {
            StringBuilder matrixAsString=new StringBuilder();
            matrixAsString.Append("  1 16 17 18 19 20");
            matrixAsString.Append("\n");
            matrixAsString.Append(" 15  2 27 28 29 21");
            matrixAsString.Append("\n");
            matrixAsString.Append(" 14 31  3 26 30 22");
            matrixAsString.Append("\n");
            matrixAsString.Append(" 13 36 32  4 25 23");
            matrixAsString.Append("\n");
            matrixAsString.Append(" 12 35 34 33  5 24");
            matrixAsString.Append("\n");
            matrixAsString.Append(" 11 10  9  8  7  6");
            matrixAsString.Append("\n");
            Matrix matrix = new Matrix(6);

            Assert.AreEqual(matrix.ToString(),matrixAsString.ToString(),"Wrong matrix!");
        }
    }
}
