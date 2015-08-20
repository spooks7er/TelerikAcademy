namespace RotatingMatrixWalk.Tests
{
    using System;
    using System.Text;
    using System.IO;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MainTests
    {
        [TestMethod]
        public void MatrixConsoleOutputShouldBeAsExpectedWhenAValidMatrixIsCreated()
        {
            using (StringWriter testStringWriter = new StringWriter())
            {
                Matrix testMatrix = new Matrix(6);

                Console.SetOut(testStringWriter);

                RotatingMatrixWalk.Main(new string[] { testMatrix.Field.GetLength(0).ToString() });

                StringBuilder expected = new StringBuilder();
                for (int i = 0; i < testMatrix.Field.GetLength(0); i++)
                {
                    for (int j = 0; j < testMatrix.Field.GetLength(0); j++)
                    {
                        expected.AppendFormat("{0,3}", testMatrix.Field[i, j]);
                    }

                    expected.Append(Environment.NewLine);
                }
                expected.Append(Environment.NewLine);
                string expectedString = expected.ToString();

                Assert.AreEqual(expectedString, testStringWriter.ToString());
            }
        }
    }
}
