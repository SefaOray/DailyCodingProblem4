using System;
using System.Linq;

namespace DailyCodingProblem4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int FindLowestMissingPosivite(int[] numbers)
        {
            Array.Sort(numbers);

            int lowest = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers.Contains(lowest))
                {
                    lowest++;
                    continue;
                }

                return lowest;
            }

            return lowest;
        }
    }
}
