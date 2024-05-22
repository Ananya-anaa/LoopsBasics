using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoops
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            string s = "hy";
            string s1 = "hi";
            char c = 'a';
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine("hello" + s);
            Console.WriteLine(c + s1);
            Console.WriteLine(a++);
            Console.WriteLine(a % b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
        }
    }
}
