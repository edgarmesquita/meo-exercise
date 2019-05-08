using MeoExercise.Calculator;
using System;
using Xunit;

namespace MeoExercise.Test
{
    public class DividersCalculatorTest
    {
        [Theory]
        [ClassData(typeof(DividersCalculatorTestData))]
        public void SutCalculatorReturnValidDistinctNumbers(params int[] input)
        {
            var dividersCalculator = new DividersCalculator();
            var output = dividersCalculator.Calculate(input);

            var expectation = new (int a, int b)[]
            {
                (1, 1), (9, 1), (9, 9), (9, 3), (3, 1), (3, 3), (4, 1), (4, 4), (4, 2), (5, 1), (5, 5), (6, 1), (6, 3), (6, 6), (6, 2), (2, 1), (2, 2)
            };

            Assert.Equal(output, expectation);
        }

        [Theory]
        [ClassData(typeof(DividersCalculatorTestData))]
        public void SutCalculatorReturnValidNumbers(params int[] input)
        {
            var dividersCalculator = new DividersCalculator();
            var output = dividersCalculator.Calculate(input, false);

            var expectation = new (int a, int b)[]
            {
                (1, 1), (9, 1), (9, 9), (9, 3), (9, 9), (3, 1), (3, 3), (4, 1), (4, 4), (4, 2), (5, 1), (5, 5), (6, 1), (6, 3), (6, 6), (6, 2), (2, 1), (2, 2), (9, 1), (9, 9), (9,3), (9, 9)
            };

            Assert.Equal(output, expectation);
        }
    }
}
