namespace ShiftedUpFiveExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Write a program that outputs all possibilities to put + or - or nothing between the numbers 1, 2, ..., 9 (in this order) such that the result is always 100. 
    /// For example: 1 + 2 + 34 – 5 + 67 – 8 + 9 = 100.
    /// </summary>
    class Problem5
    {
        public void GeneratePosibilities(int expectedNumber)
        {
            Recursive(expectedNumber, 1, 0, new List<string>());
        }

        void Recursive(int expectedNumber, int index, int currentResult, List<string> currentValues)
        {
            if (currentResult > expectedNumber || index > 10)
            {
                return;
            }
            if (currentResult == expectedNumber)
            {
                Console.WriteLine();
                currentValues.ForEach(Console.Write);
            }

            var positive = new List<string>(currentValues);
            positive.Add("+" + index.ToString());
            var negative = new List<string>(currentValues);
            negative.Add((index * -1).ToString());
            var nothing = new List<string>(currentValues);

            Recursive(expectedNumber, index + 1, currentResult + index, positive);
            Recursive(expectedNumber, index + 1, currentResult - index, negative);

            if (currentResult >= 0)
            {
                nothing.Add("+" + (10 * index).ToString());
                Recursive(expectedNumber, index + 1, currentResult + (10 * index), nothing);
            }
            else
            {
                nothing.Add((10 * index * -1).ToString());
                Recursive(expectedNumber, index + 1, currentResult - (10 * index), nothing);
            }

        }
    }
}
