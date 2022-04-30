using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace reverse
{
    class Program
    {
        class Reverse
        {
            public bool Rev(int tal)
            {
                int temp = tal;
                int rev, rem = 0;
                if(tal < 0)
                {
                    
                    return false;
                }
                while(tal != 0)
                {
                    rev = tal % 10;
                    rem = (rem * 10) + rev;
                    tal /= 10;
                }
                Console.WriteLine("before: " +temp);
                Console.WriteLine("after: " + rem);
                if(temp == rem)
                {
                    Console.WriteLine("its palindrome");
                    return true;
                }
                Console.WriteLine("its not palindrome");
                return false;
            }
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                while (true)
                {
                    try
                    {
                        Console.Write("Enter a number: ");
                        int number = int.Parse(Console.ReadLine());
                        Reverse rev = new Reverse();
                        rev.Rev(number);
                        Thread.Sleep(1000);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("It need to be a possitive whole number!");
                        Thread.Sleep(1000);
                        break;
                    }
                }
                Console.ReadLine();
               
            }
        }
    }
}
