using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Search(int [] arr, int target,int counter)
        {
            int low = 0;
            int high = arr.Length-1;
            while(low<=high)
            {
                int middle = low + (high - low) / 2;
                Console.WriteLine("middle: "+ middle);
                
                if (middle < target)
                {
                    low = middle + 1;
                    counter++;

                }
                else if(middle > target)
                {
                   high = middle - 1;
                   counter++;


                }
                else if(middle == target)
                {
                    Console.WriteLine("splits: " + (counter+1));
                    return middle;
                }
                
            }
            Console.WriteLine("splits: " + (counter + 1));
            Console.Write("target not inside of arrey: "+ target);
            Console.WriteLine();
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[1000];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            int target = 498;
            int counter = 0;
            Console.WriteLine("Binary Search");
            Search(arr, target,counter);
            Console.WriteLine("Linear Search");
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    Console.WriteLine("target: " + target);
                }
                if (arr[i] == target)
                {
                    continue;
                }
                arr[i] = i;
                Console.WriteLine(arr[i]);
              

                
            }

            Console.ReadLine();
        }
    }
}
