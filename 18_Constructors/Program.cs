using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //s1.deatils();
            //Student s2 = new Student();
            //s2.Rollnumber = 1;
            //s2.Firstname = "Nilesh";
            //s2.Lastname = "kumre";
            //s2.deatils();

            //// object initiakizer syntax
            //Student s3 = new Student()
            //{
            //    Rollnumber = 2,
            //    Firstname = "sony",
            //    Lastname = "athram"

            //};
            //s3.deatils();
            //Student s4 = new Student();
            //s4.initialize(12, "ajay", "more");
            //s4.deatils();

            //Student s5 = new Student();
            //s5.deatils();
            
            
            //Student s6 = new Student(05,"kunal","topale");
            //s6.deatils();

            //Student s7 = new Student(06, "suraj", "ade");
            //s7.deatils();




            //Student s8= new Student();
            //Student s9= new Student(12,"aniket","patakr");

            Student s9 =new Student(12,"nikhil","kumre");
            s9.deatils();

            Student s10 = s9;  // s10 & s9 will point same object in heap
            s10.deatils();

            Student s11 = new Student();
            s11.Rollnumber=s10.Rollnumber;
            s11.Firstname=s10.Firstname;
            s11.Lastname=s10.Lastname;
            s11.deatils();

            Student s12 = new Student(s11);
            s12.deatils();

            Student s13 = new Student();
            s13.deatils();
            Student s14 = new Student();
            s13.deatils();
            Student s15 = new Student();
            s13.deatils();


            Console.ReadLine();
        }
    }
}
