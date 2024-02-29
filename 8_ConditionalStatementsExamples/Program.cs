using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ConditionalStatementsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //Console.WriteLine("please enter first number");
            //int first = int.Parse(Console.ReadLine());

            //Console.WriteLine("please enter second number");
            //int second = int.Parse(Console.ReadLine());

            //Console.WriteLine("please enter third number");
            //int third = int.Parse(Console.ReadLine());

            //Console.WriteLine($" you entered number : {first},{second},{third}");


            #region nested if else
            //if (First > Second)   
            //{
            //    if(First > Third)
            //    {
            //        Console.WriteLine($" {First} is greter number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{Third} is greter number");
            //    }
            //}
            //else if(Second > First)
            //{
            //    if(Second > Third)
            //    {
            //        Console.WriteLine($" {Second} is greter number");

            //    }
            //    else
            //    {
            //        Console.WriteLine($"{Third} is greter number");
            //    }
            //}
            //else 
            //{
            //    if(Second > Third)
            //    {
            //        Console.WriteLine($"{First},{Second} are greater number");
            //    }
            //    else if(Second==Third)
            //        {
            //           Console.WriteLine($"{First},{Second},{Third} are equal");

            //    }
            //    else 
            //    {
            //        Console.WriteLine($"{Third} is greteer number");

            //    }
            //}

            ////else
            ////{
            ////    Console.WriteLine($"{First},{Second},{Third} are equal");
            ////}


            #endregion nested if else

            #region Nested Ternary else
            ////int number = (first > second) ? first : second:
            //int number = (first > second) ?((first > third) ? first : third) : 
            //             (second>third) ? second: third;    

            //Console.WriteLine($"{number} is Greater Number");

            #endregion #region Nested Ternary else

            #region Divisible 3 & 5
            //// if input number is divisble by 3 = THREE
            //// if input number is divisible by 5 = FIVE
            //// if input number is divisible by 3 & 5 = THREE FIVE

            //Console.WriteLine("please enter a number");
            //int num =int.Parse(Console.ReadLine()); 

            //if (num % 3 ==0)
            //{
            //    Console.WriteLine("THREE");
            //}
            //else if(num % 5 ==0)

            //{
            //    Console.WriteLine("FIVE");
            //}
            //else if(num % 3 ==0  && num %5 ==0)
            //{
            //    Console.WriteLine("THREE FIVE");
            //}
            #endregion Divisible 3 & 5

            #region Even & Odd

            //Console.WriteLine("please enter a number");
            //int numbers = int.Parse(Console.ReadLine());

            //string result = (numbers % 2 == 0) ? "EVEN" : "ODD";
            //Console.WriteLine($"{numbers} is {result} number");

            #endregion Even & Odd

            #region Grade meaning

            //Console.WriteLine("Please enter a grade");
            //char grade = char.Parse(Console.ReadLine());

            //switch(grade)
            //{
            //    case 'A':
            //        Console.WriteLine($" {grade} : Distinction ");
            //        break;
            //    case 'b':
            //        Console.WriteLine($" {grade} : First class ");
            //        break;
            //    case 'c':
            //        Console.WriteLine($" {grade} : Second class ");
            //        break;
            //    case 'd':
            //        Console.WriteLine($" {grade} : third class");
            //        break;
            //    case 'f':
            //        Console.WriteLine($" {grade} : failed");
            //        break;

            //    default:
            //        Console.WriteLine($" {grade} : invalidgrade");
            //        break;
            //}
            #endregion Grade meaning

            #region pattern printing loop 

            //for (int i=1;i<=5;i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {

            //            Console.WriteLine("* ");

            //    }
            //    Console.WriteLine();
            //}

            #endregion pattern printing loop 

            int x, y, z;
            for(x=6;x>=1;x--)
            {
                for(y=0;y<x;y++)
                {
                    Console.Write("  ");
                }
                for (z = 6; z >= x; z--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }





            Console.ReadLine();
        }
    }
}