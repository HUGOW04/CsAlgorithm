using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static string Reverse(string s)
        {
            char[] charArrey = s.ToCharArray();
            int total = charArrey.Length-1;
            string bok = "";
            for (int i = total; i>=0; i--)
            {
                bok = bok + charArrey[i];
            }
            return bok;
        }
        static void Main(string[] args)
        {
            Console.Write("Skriv ngt: ");
            string s = Console.ReadLine();
            Console.WriteLine(s);
            Console.WriteLine(Reverse(s)); 
            Console.WriteLine();
            if(s == Reverse(s))
            {
                Console.WriteLine("It is anagram");
            }
            else
            {
                Console.WriteLine("It's not anagram");
            }
            Console.ReadLine();            
        }
    }
}
