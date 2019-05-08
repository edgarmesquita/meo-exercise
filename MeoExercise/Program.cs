using MeoExercise.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MeoExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 1, 9, 3, 4, 5, 6, 2, 9 };

            var dividersCalculator = new DividersCalculator();


            Console.WriteLine("Fase 1:");
            WriteOutputs(dividersCalculator.Calculate(input));
            Console.WriteLine("");
            Console.WriteLine("Fase 2:");
            WriteOutputs(dividersCalculator.Calculate(input, false));
            Console.ReadLine();
        }

        private static void WriteOutputs((int a, int b)[] output)
        {
            foreach (var item in output)
                Console.WriteLine($"{item.a} div {item.b}");
        }
    }
}
