using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{

    /*   Write a C# Sharp program to read n values in an array and display them in reverse order.
       Test Data :
       Input the number of elements to store in the array :3
       Input 3 number of elements in the array :
       element - 0 : 2
       element - 1 : 5
       element - 2 : 7
       Expected Output:
       The values store into the array are:
       2 5 7
       The values store into the array in reverse are :
       7 5 2*/
    internal class problem2
    {
        public static void reverseArray()
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

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
