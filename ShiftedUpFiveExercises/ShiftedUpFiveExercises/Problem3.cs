namespace ShiftedUpFiveExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Write a function that computes the list of the first 100 Fibonacci numbers. 
    /// By definition, the first two numbers in the Fibonacci sequence are 0 and 1, 
    /// and each subsequent number is the sum of the previous two. As an example, 
    /// here are the first 10 Fibonnaci numbers: 0, 1, 1, 2, 3, 5, 8, 13, 21, and 34.
    /// </summary>
    class Problem3
    {
        public void FibonacciIterative(int numbers)
        {
            var results = new List<double>() { 0, 1 };

            for (int i = 2; i < numbers; i++)
            {
                results.Add(results[i - 1] + results[i - 2]);
            }

            results.ForEach(Console.WriteLine);
        }
    }
}
