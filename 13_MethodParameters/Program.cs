using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_MethodParameters
{
    internal class Program
    {
        static void Main(string[] args) //calling method
        {
            //int a = 10;     
            //printA(a);
            //Console.WriteLine(a);

            //int a = 10;
            //printb(ref a);
            //Console.WriteLine(a);

            int c;
            printC(out c);
            Console.WriteLine(c);

            int a = 10, b = 2, add, sub, mul, div;
            print(a, b, out add, out sub, out mul, out div);
            Console.WriteLine($"Addition : {a} + {b} ={add}");
            Console.WriteLine($"Substraction : {a} - {b} ={sub}");
            Console.WriteLine($"Multiplication : {a} *{b} ={mul}");
            Console.WriteLine($"Division : {a} / {b} ={div}");

            Console.ReadLine();


        }
        static void printA(int a) // called method
        {
            a = 100;
        }

        static void printb(ref int b)
        {
            //b = 200; //no error
        }

        static void printC(out int c)
        {
            c = 300;
        }

        // write a single method which returns add, sub,div,multuplication
        static void print(int a,int b,out int add,out int sub,out int mul,out int div)
        {
            add = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;

        }
    }
}
