using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 5, 4, -3, 1, 2, 9 }; // count = 6
            int target = 6;
            int left = 0;
            int right = list.Count - 1; // 5

            list.Sort();//{-3, 1, 2, 4, 5, 9}

            while (left < right)
            {
                int sum = list[left] + list[right];
                if (sum == target)
                {
                    Console.WriteLine($"{list[left]} {list[right]}");
                    left++;
                    right--;
                }

                else if (sum < target)
                {
                    left = left + 1;
                }

                else if (sum > target)
                {
                    right = right - 1;
                }
            }
        }
    }
}
