using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArrayProblems
{
    internal class problem13
    {
        public static void add()
        {
            Console.WriteLine(" element to add:");
            int ele = int.Parse(Console.ReadLine());
            int[] arr = {3,5,6,7,8,9,10};

            arr[arr.Length]=ele;

            Array.Sort(arr);

            // Print the sorted array
            Console.WriteLine("Modified array:");
            string result = string.Join(", ", arr);
            Console.WriteLine(result);

        }
    }
}
