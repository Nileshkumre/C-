using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)// Calling method
        {
            printA();// method call
            printB("Nilesh");// nilesh value => method argument
            string name = "mahi";
            printB(name);// name => method argument
            printC("nilesh", "sony");
            string firstname = "rahual", lastname = "Triveni";
            printC(firstname, lastname);
            
            //Console.WriteLine($"printD() Full name : {result}");

            printE(true);
            printE(false);
            printF(null);// no Items to add
            int[] numbers = new int[] { 10, 20, 30 };
            printF(numbers);//60
            Console.ReadLine();
            int[] num = new int[] { 10, 20 };
            printz(num);
        }

        // calling method ->  method from where another method is getting called
        // called method -> method which is getting called from another method 
        // 1 method without return without parameter


        static void printA() // Called method
        {
            Console.WriteLine("printA() Method called");
        }


        // 2 method without return with parameter
        static void printB(string name) // name => method parameter
        {
            Console.WriteLine($"printb() : Hello, {name}");
        }

        // 3 method without return multiple parameters
        static void printC(string fn,string ln)
        {
            Console.WriteLine($"printC() Full name : {fn} {ln}");
        }

       
        
        // 4 method with retrun type with parameter
        static string printD(string fn,string ln)
        {
            return fn + " " + ln;
        }

        static void printE(bool isConfirmed)
        {
            if (! isConfirmed)
            {
                return;
            }
            Console.WriteLine($"printE({isConfirmed}) : Session allowed");
        }

        static void printF(int[] numbers)
        {
            if (numbers !=null && numbers.Length > 0)
            {
                int sum = 0;
                for (int i = 0;i<numbers.Length;i++)
                {
                    sum =sum + numbers[i];
                }
                Console.WriteLine($"sum of array item : {sum}");
            }
            else
            {
                Console.WriteLine("No Numbers to add");
            }
        }
    }
}
