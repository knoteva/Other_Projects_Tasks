using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int> {-3, 1, 2, 9 }; // count = 6
            int target = 6;
            int[] arr = new int[2];
            //list.Sort();//{-3, 1, 2, 4, 5, 9}

            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = nums.Count - 1; j > 0; j--)
                {
                    
                    if (nums[i] + nums[j] == target)
                    {
                        arr[0] = i;
                        arr[1] = j;
                    }
                }

            }
            //return arr;
        }
    }
}
