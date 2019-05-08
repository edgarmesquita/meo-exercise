using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeoExercise.Calculator
{
    public class DividersCalculator
    {
        public (int a, int b)[] Calculate(int[] input, bool distinct = true)
        {
            var outputs = new List<(int a, int b)>();
            foreach (var i in input)
            {
                var divs = input.Where(o => i % o == 0);
                foreach (var div in divs)
                {
                    var item = (i, div);
                    if (!distinct || !outputs.Contains(item))
                    {
                        outputs.Add(item);
                    }
                }
            }
            return outputs.ToArray();
        }
    }
}
