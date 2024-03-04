using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_ClassObjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int i = 0; // i is a variable of type int 
            //student s1; // s1 is variable of type student
            // s1 is reference variable
            student s1 =new student();// object or instance of student class
            s1.Rollnumber = 1;
            s1.name = "nilesh";
            s1.city = "pune";
            student.Coursename = "dot net";
            s1.print();

            student s2 = new student();
            s2.create(2, "sony", "hyd");
            student.Coursename = "dot net";
            s2.print();

            student.Coursename = "c#"; // we can change value of static field
            student s3 = new student();
            s3.create(3,"ajay","pune");
            s3.print();

            Console.WriteLine($" Number of countries {world.numberofcountries}");
            Console.WriteLine($" Number of countinant {world.numberofcountinant}");




            Console.ReadLine();

        }
    }
    class student
    {
        public int Rollnumber; // instance member
        public string name;
        public string city;
        public static string Coursename; // static member

        public  void print() // non static method
        {
            Console.WriteLine($" Roll number : {Rollnumber} Name : {name} city : {city} coursename {Coursename}");
            //printA();
        }

        public void create(int rn,string names,string citys)
        {
            Rollnumber = rn;
            name = names;
            city = citys;
        }

        public static void printA()
        {
            Console.WriteLine($"static printA() called");
           // Console.WriteLine($" Roll number : {Rollnumber} Name : {name} city : {city} coursename {Coursename}");
            //print(); // not allowed to call static method directly

            // to access instance member from static method  we need  to create to object 
            //student s= new student();
            //s.create(3,"rahul","mumbai");
        }
    }

    static class world
    {
         public static int numberofcountries = 290;
         public static int numberofcountinant = 07;
    }
}
