using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = fibSeries();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            var sum = sumFibonacci(numbers);
            Console.WriteLine("========");
            Console.WriteLine(sum);
        }

        public static List<int> fibSeries()
        {
            var a = 1;
            var b = 2;
            var next = a + b;
            var fibonacciList = new List<int>();
            while (next < 4000000)
            {
                if (next % 2 ==0)
                {
                    fibonacciList.Add(next);
                }
                a = b;
                b = next;
                next = a + b;
            }
            return fibonacciList;
        }

        public static int sumFibonacci(List<int> list)
        {
            var sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum;
        }
    }
}
