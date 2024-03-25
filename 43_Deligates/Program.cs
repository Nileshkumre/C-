using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Deligates
{
    delegate void PrintDelegate(string a);    // Its Delegae Declaration 
    public class Program
    {
        static void Main(string[] args)
        {
            ////PrintA("Nilesh");
            //PrintDelegate pd = new PrintDelegate(PrintA); // Delegates instance 
            //pd("Mahi"); // 3rd Delegates call / invoke

            //PrintDelegate pd1 = PrintA;
            //PrintDelegate pd2 = PrintB;
            //PrintDelegate pd3 = PrintC;
            //PrintDelegate pd = pd1 + pd2 + pd3 -pd2;
            //pd("Nilesh");

            PrintDelegate pd = PrintA;
            pd += PrintB;
            pd += PrintC;
            //pd -= PrintA; // De register
            

            pd("Maheshwari");


            Student s = new Student();
            PrintDelegate pd1 = s.Print1;
            pd1 += s.Print2;
           // PrintDelegate pd2 = Print2;

            pd1("Nilesh");




            Console.ReadLine();
        }

        static void PrintA(string name)
        {
            Console.WriteLine($"PrintA() : Hello, {name}");
        }

        static void PrintB(string name)
        {
            Console.WriteLine($"PrintB() : Welcome, {name}");
        }

        static void PrintC(string name)
        {
            Console.WriteLine($"PrintC() : Good Morning, {name}");
        }

        static string GetName()
        {
            return "Nilesh";
        }
    }

    public class Student
    {
        public void Print1( string name)
        {
            Console.WriteLine($"PrintA() : Hello, {name}");
        }

        public void Print2(string name)
        {
            Console.WriteLine($"PrintA() : Hello, {name}");
        }

    }
}
