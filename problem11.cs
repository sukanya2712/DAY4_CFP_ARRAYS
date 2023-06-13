using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal class problem11
    {

        /*11. Write a C# Sharp program to sort elements of an array in ascending order.
Test Data :
Input the size of array : 5
Input 5 elements in the array :
element - 0 : 2
element - 1 : 7
element - 2 : 4
element - 3 : 5
element - 4 : 9
Expected Output :
Elements of array in sorted ascending order:
2 4 5 7 9*/
        public static void sorting()
        {
            int[] numbers = { 5, 2, 8, 1, 9 };

for (int i = 0; i<numbers.Length - 1; i++)
{
    for (int j = 0; j<numbers.Length - i - 1; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            // Swap elements
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
}

        }

    }
}
