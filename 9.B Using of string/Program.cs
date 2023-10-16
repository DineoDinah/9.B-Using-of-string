using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.B_Using_of_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("FizzBuzz"));
            Console.WriteLine(test("Fizz"));
            Console.WriteLine(test("Buzz"));
            Console.WriteLine(test("Founder"));
            Console.ReadLine();
        }
        public static string test(string string1) 
        {
            if (string1.StartsWith("F") && string1.EndsWith("B"))
            {
                return "FizzBuzz";
            }
            else if (string1.StartsWith("F"))
            {
                return "Fizz";
            }
            else if (string1.EndsWith("B"))
            {
                return "Buzz";
            }
            else 
            { 
                return string1;
            }
        }
    }
}
