namespace ShiftedUpFiveExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Write a function that given a list of non negative integers, arranges them such that they form the largest possible number. 
    /// For example, given [50, 2, 1, 9], the largest formed number is 95021.
    /// </summary>
    class Problem4
    {
        int largest = 0;

        public void ArrangeWeird(List<int> list)
        {
            var stringList = list
                .Select(i => i.ToString())
                .OrderByDescending(i => i)
                .ToList();

            Console.WriteLine();
            stringList.ForEach(Console.Write);
            Console.WriteLine();
        }

        public void ArrangeRecursive(List<int> list)
        { }

        void Arrange(List<int> list, int selectedPosition, int index, int max)
        {
            if (index == list.Count)
            {
                if (max > largest)
                {
                    largest = max;
                }
            }
            else
            {

            }
        }
    }
}
