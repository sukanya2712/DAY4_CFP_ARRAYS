using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal class problem14
    {

        public static void duplicate()
        {
            int[] arr = { 10, 20, 20, 40, 50, 29, 18 };
            int sum = 180;
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i]*arr[j] == sum)
                    {
                        Console.WriteLine(arr[i] + "and" + arr[j]);
                        return;
                    }
                }
                Console.WriteLine("No pair found.");
            }
        }
    }
}
