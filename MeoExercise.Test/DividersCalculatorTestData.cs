using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MeoExercise.Test
{
    public class DividersCalculatorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1, 9, 3, 4, 5, 6, 2, 9 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
