using System;
using System.Collections.Generic;

namespace Challenge_Task
{
    class MMaxAlgorithm
    {
        static void Main()
        {
            var capacity = int.Parse(Console.ReadLine());
            var expenses = new List<int>();
            var marketability = new List<int>();
            string line;

            while ((line = Console.ReadLine()) != "Stop")
            //Input format:
            //8
            //1 1
            //2 2
            //2 3
            //2 4
            //2 5
            //Stop
            {
                expenses.Add(int.Parse(line.Split(" ")[0]));
                marketability.Add(int.Parse(line.Split(" ")[1]));
            }
            int itemsCount = marketability.Count;
            int result = MMax(capacity, expenses, marketability, itemsCount);
            Console.WriteLine($"Максимална товароспособност: {result}");

        }
        public static int MMax(int capacity, List<int> expenses, List<int> marketability, int itemsCount)
        {
            int[,] matrix = new int[itemsCount + 1, capacity + 1];

            for (int i = 1; i <= itemsCount; i++)
            {

                for (int j = 1; j <= capacity; j++)
                {

                    if (expenses[i - 1] <= j)
                    {
                        matrix[i, j] = Math.Max(marketability[i - 1] + matrix[i - 1, j - expenses[i - 1]], matrix[i - 1, j]);
                    }

                    else
                    {
                        matrix[i, j] = matrix[i - 1, j];
                    }
                }
            }

            return matrix[itemsCount, capacity];
        }
    }
}