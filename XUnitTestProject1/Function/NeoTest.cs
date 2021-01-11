using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1.Function
{
    public class NeoTest
    {
        [Fact]
        public void PassingTest()
        {
            int a = 2;
            int b = 2;
            int expectedSum = 4;
            int actualSum = ConsoleApp1.Func.Neo.Add(a, b);
            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void FailingTest()
        {
            int a = 2;
            int b = 2;
            int expectedSum = 5;
            int actualSum = ConsoleApp1.Func.Neo.Add(a, b);
            Assert.NotEqual(expectedSum, actualSum);
        }
    }
}
