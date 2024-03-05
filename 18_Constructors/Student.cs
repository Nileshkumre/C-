using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Constructors
{
    public class Student
    {
        public int Rollnumber;
        public string Firstname;
        public string Lastname;
        public static string Coursename;
        //default constructor / parameter less constructor
        public Student()
        {
            Console.WriteLine($"student constructor called");
            Rollnumber = 1;
            Firstname = "nilesh";
            Lastname = "kumre";
            Coursename = "dot net";
        }

        //parameterized constructor
        public Student(int rn,string fn,string ln)
        {
            Console.WriteLine($"Student(int rn,string fn,string ln) constructor called");
            Rollnumber = rn;
            Firstname = fn;
            Lastname = ln;
        }
        // copy consturctor
        public Student(Student s)
        {
            this.Rollnumber = s.Rollnumber;
            this.Firstname = s.Firstname;
            this.Lastname = s.Lastname;

        }
        public void deatils()
        {
            Console.WriteLine($"Rollnumber :  {Rollnumber} First name : {Firstname} Last name : {Lastname} course name : {Coursename}");

        }

        public void initialize(int rn, string fn, string ln)
        {
            Rollnumber = rn;
            Firstname = fn; 
            Lastname = ln;

        }
    }
}
