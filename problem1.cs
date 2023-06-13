﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class problem1
    {
        /*
       1. Write a C# Sharp program that stores elements in an array and prints them.
           Test Data:
           Input 10 elements in the array:
           element - 0 : 1
           element - 1 : 1
           element - 2 : 2
           .......
           Expected Output :
           Elements in array are: 1 1 2 3 4 5 6 7 8 9*/
        public static void array()
        {
            Console.WriteLine("Enter size of the array: - ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter {i + 1} element of array");
                int element = int.Parse(Console.ReadLine());
                array[i] = element;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}