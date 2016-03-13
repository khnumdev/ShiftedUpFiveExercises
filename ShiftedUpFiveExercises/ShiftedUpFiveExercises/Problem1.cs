namespace ShiftedUpFiveExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Write three functions that compute the sum of the numbers in a given list using a for-loop, a while-loop, and recursion.
    /// </summary>
    class Problem1
    {
        public void ForLoop(IList<int> list)
        {
            var result = 0;

            if (list != null && list.Any())
            {
                for (int i = 0; i < list.Count; i++)
                {
                    result += list[i];
                }
            }

            Console.WriteLine(result);
        }

        public void WhileLoop(IList<int> list)
        {
            var result = 0;

            if (list != null && list.Any())
            {
                var listPosition = 0;
                while (listPosition < list.Count)
                {
                    result += list[listPosition];

                    listPosition++;
                }
            }

            Console.WriteLine(result);
        }

        public void Recursive(IList<int> list)
        {
            var result = Recursive(0, list);

            Console.WriteLine(result);
        }

        private int Recursive(int position, IList<int> list)
        {
            var result = 0;

            if (position < list.Count)
            {
                result = list[position] + Recursive(position + 1, list);
            }

            return result;
        }
    }
}
