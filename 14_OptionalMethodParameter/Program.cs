using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _14_OptionalMethodParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add(10, 20);
            Add(10);
            Adds(b: 20);

            
            sum(a:5, c:15);
         
            Console.ReadLine();
        }
        static void Add(int a, [Optional] int b ) // b = 5 => Default value 
        {
            Console.WriteLine($"Addition : {a} + {b} = {a + b}");
        }

        static void Adds([Optional]  int a,  int b)
        {
            Console.WriteLine($"Addition : {a} + {b} = {a + b}");
        }

        static void sum(int a, [Optional] int b,int c)
        {
            Console.WriteLine($"Addition :{a}+{b}+ {c} = {a+b+c}");
        }

    }
}
