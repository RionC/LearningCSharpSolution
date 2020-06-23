using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class TestingBasics
    {
        [Fact]
        public void CanAddTwoNumbers()
        {
            int a = 10, b = 20;

            int answer = a + b;

            Assert.Equal(30, answer);
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(5, 5, 10)]
        [InlineData(20, 5, 25)]
        public void CanAddNumbers(int a, int b, int expected)
        {
            int answer = a + b;
            Assert.Equal(expected, answer);
        }
    }
}
