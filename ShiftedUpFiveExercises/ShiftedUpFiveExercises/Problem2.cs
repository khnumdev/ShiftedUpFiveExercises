namespace ShiftedUpFiveExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Write a function that combines two lists by alternatingly taking elements. 
    /// For example: given the two lists [a, b, c] and [1, 2, 3], the function should return [a, 1, b, 2, c, 3].
    /// </summary>
    class Problem2
    {
        public void Combine(List<object> firstList, List<object> secondList)
        {
            List<object> result = new List<object>();

            if (firstList != null && secondList != null
                && firstList.Count == secondList.Count)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[i]);
                }
            }

            foreach (var item in result)
            {
                Console.Write(item);
            }
        }
    }
}
