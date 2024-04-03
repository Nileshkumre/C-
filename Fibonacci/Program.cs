using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fibonacci
            int n;
            Console.WriteLine("Fibonacci series");
            Console.Write("Enter number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci series");
            int a = 0, b = 1, c;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{a}");
                c = a + b;
                a = b;
                b = c;
            }
            #endregion Fibonacci

            #region Palindrome
            // Console.WriteLine("Please enter Name");
            // string str=Console.ReadLine();
            //string nstr = "";
            // for (int i = str.Length-1; i >=0; i--) 
            // {
            //    nstr+= str[i];
            // }

            // if (nstr == str)
            // {
            //     Console.WriteLine("Input String Is Palindrome");
            // }
            // else
            // {
            //     Console.WriteLine("Input String Is Not Palindrome");
            // }
            #endregion Palindrome

            #region reverse a string
            //Console.WriteLine("please enter your name:");
            //string name = Console.ReadLine();
            //string reversename = "";
            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    reversename += name[i];
            //}
            //Console.WriteLine(reversename);
            //Console.ReadLine();

            #endregion reverse a string

            #region reverse given array

            //int[] number = new int[5] { 4, 2, 5, 7, 11 };
            //Console.WriteLine($"lenght of number :{number.Length} numbers");
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.Write($"{number[i]}");
            //}

            //Console.WriteLine("\n Reverse array");
            //for (int i = number.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{number[i]}");
            //}

            #endregion reverse given array



            Console.ReadLine();

        }
    }


}
