using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ClassDemo
{
    internal class Program

    {

        static void Main(string[] args)
        {
            int rollnumber = 10;
            string name = "Nilesh";
            string city = "pune";
            Console.WriteLine($"Rollnumber : {rollnumber}\n" +
                $"name: {name}\n" + 
                $"city : {city}");

            student s1 = new student();   // instance / object

            s1.rollnumber = 11;
            s1.name = "nilesh";
            s1.city = "mumbai";

            //Console.WriteLine($" Rollnumber: {s1.rollnumber} Nmae : {s1.name}  city : {s1.city}");
            s1.details();
            student s2 = new student();
            s2.rollnumber = 12;
            s2.name = "sony";
            s2.city = "Hyderabad";

            //Console.WriteLine($" Rollnumber: {s2.rollnumber} Nmae : {s2.name}  city : {s2.city}");
            s2.details();

            Circle c1 =new Circle();
            c1 .Radius = 10;
            //c1.pi = 3.14f;
            c1.Area();

            Circle c2 =new Circle();
            c2.Radius = 20;
            //c2.pi = 3.14f;
            c2.Area();

            Console.WriteLine($"pi : {Circle.pi} ");
            Console.ReadLine();
        }
    }

    class student
    {
        // class fields // data member
        public int rollnumber;
        public string name;
        public string city;

        //member function/ methods
        public void details()
        {
            Console.WriteLine($" Rollnumber: {rollnumber} Nmae : {name}  city : {city}");
        }

    }  


    



}
