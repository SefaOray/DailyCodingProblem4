using System;
using Xunit;
using DailyCodingProblem4;

namespace DailyCodingProblem4.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 3, 4, -1, 1 }, 2)]
        [InlineData(new int[] { 1, 2, 0 }, 3)]
        public void Test_lowest_missing_positive(int[] numbers, int expectedResult)
        {
            var result = Program.FindLowestMissingPosivite(numbers);

            Assert.Equal(expectedResult, result);
        }
    }
}
