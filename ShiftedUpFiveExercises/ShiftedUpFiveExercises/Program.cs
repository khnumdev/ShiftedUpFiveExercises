using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftedUpFiveExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem1 = new Problem1();
            var list = new List<int> { 1, 2, 3, 4 };

            problem1.ForLoop(list);
            problem1.WhileLoop(list);
            problem1.Recursive(list);

            var problem2 = new Problem2();
            var problem2FirstList = new List<object> { "a", "b", "c" };
            var problem2SecondList = new List<object> { 1, 2, 3 };

            problem2.Combine(problem2FirstList, problem2SecondList);

            var problem3 = new Problem3();

            problem3.FibonacciIterative(10);
            problem3.FibonacciIterative(100);

            var problem4 = new Problem4();
            var problem4List = new List<int> { 50, 2, 1, 9 };

            problem4.ArrangeWeird(problem4List);

            var problem5 = new Problem5();
            problem5.GeneratePosibilities(100);

            Console.ReadLine();
        }
    }
}
