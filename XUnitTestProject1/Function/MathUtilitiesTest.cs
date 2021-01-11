using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1.Function
{
    public class MathUtilitiesTest
    {
        [Fact]
        public void PassingTest()
        {
            int a = 2;
            int b = 2;
            int expectedSum = 4;
            int actualSum = MathUtilities.Add(a, b);
            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void FailingTest()
        {
            int a = 2;
            int b = 2;
            int expectedSum = 5;
            int actualSum = MathUtilities.Add(a, b);
            Assert.NotEqual(expectedSum, actualSum);
        }
    }
}
