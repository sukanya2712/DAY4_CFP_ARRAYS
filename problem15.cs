using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal class problem15
    {
        public static void sumof()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                
                if (isprime(arr[i]))
                {
                    sum += arr[i];
                }

            }
            Console.WriteLine(sum);

            static bool isprime(int num){
                if(num <= 1) {
                    return false;
                }
                else
                {
                    for(int i=2; i <=Math.Sqrt(num); i++) 
                    {
                        if(num%i == 0)
                        {
                            return false;
                        }
                    }
                }
                return true;
                
            }
        }
    }
}
