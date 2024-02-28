using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_conditionalstatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            if(i==10)
            {
                Console.WriteLine($" {i} : TEN");
            }

            else
            {
                Console.WriteLine($" {i} : NOT A TEN");
            }


            //Console.WriteLine($" {i} : TEN");
            //ternary operetor
            //(condition) ? statement1 : statement2;
            //i = 30;
            //string result =(i == 10) ? "TEN" : "NOT TEN";
            //Console.WriteLine($" {i} : {result}");
            //i = 40;
            //if (i == 10)
            //{
            //    Console.WriteLine($"{i} : TEN");

            //}
            //else if (i == 20)
            //{
            //    Console.WriteLine($"{i} : TWENTY");
            //}
            //else if (i == 30)
            //{
            //    Console.WriteLine($" {i}: THIRTY");
            //}
            //else
            //{
            //    Console.WriteLine($"{i} : NOT IN 10,20 or 30");
            //}

            // switch
            //i = 100;
            //switch (i)
            //{
            //    case 10:
            //        Console.WriteLine($"{i} : TEN");
            //        break;
            //    case 20:
            //        Console.WriteLine($"{i}: TWEMTY");
            //        break;
            //    case 30:
            //        Console.WriteLine($"{i}: THIRTY");
            //        break;
            //    default: Console.WriteLine($"{i} : NOT 10 20 or 30");
            //        break;

            //}

            int a = 10, b = 20;
            if(a>b)
            {
                Console.WriteLine($" {a} is greter than {b}");
            }
            else if (b>a)
            {
                Console.WriteLine($" {a} is less than {b}");

            }
            else
            {
                Console.WriteLine($" {a} and {b} are equal");
            }


            Console.WriteLine(DateTime.Now);




              Console.ReadLine();

        }
    }
}
