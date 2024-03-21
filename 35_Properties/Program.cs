using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _35_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s1= new Student();

            //s1.RollNumber = 1;  //assign setting /Write
            //s1.Name = "Nilesh";
            //s1.passmark = 35;
            //Console.WriteLine($"RollNumber : {s1.RollNumber}" + $"Name : {s1.Name}" + $"passmark : {s1.passmark}");

            //Student s2 = new Student();
            //Student s2 = new Student();
            //s2.SetRollNumber(-1);
            //s2.SetName("Nilesh");

            //Console.WriteLine($"Roll Number : {s2.GetRollNumber()}" +
            //    $"Name : {s2.GetName()}" "   " + $"{s2.GetPassmark()}");

            Student s = new Student();
            s.RollNumber = 1;
            s.name = "Nilesh";
            Console.WriteLine($"Roll Number : {s.RollNumber} name : {s.name} passmark : {s.Passmark}");

            Student s1 = new Student();
            s1.RollNumber = 2;
            s1.name = null;
            s1.city = "mumbai";
            Console.WriteLine($"Roll NUmber : {s1.RollNumber} Name : {s1.name} passmark : {s1.Passmark}  City : {s1.city}");
            Console.ReadLine();



        }
    }
    //public class Student
    //{
    //    public int RollNumber;
    //    public String Name;
    //    public int passmark= 35;

    //}
    //public class Student
    //{
    //    private int _rollNumber;
    //    private String _name;
    //    private int _passmark= 35; 

    //    public void SetRollNumber(int rollNumber)
    //    {
    //        if(rollNumber >0)
    //        {
    //            _rollNumber = rollNumber;
    //        }
    //        else
    //        {
    //            _rollNumber = 0;
    //            Console.WriteLine("RollNumber cannot be negative");
    //        }
    //    }

    //    public int GetRollNumber()
    //    {
    //        return _rollNumber;
    //    }

    //    public void SetName(String name)
    //    {
    //        _name=name;
    //    }
    //    public string GetName()
    //    {
    //        return !string.IsNullOrEmpty( _name ) ? _name : "No name provdied";
    //    }

    //    public int GetPassmark()
    //    {
    //        return _passmark;
    //    }
    //}
    public class Student
    {
        private int _rollNumber;
        private String _name;
        private int _passmark = 35;
        private char email;
         

        public int RollNumber
        {
            get
            {
                return _rollNumber;
            }
            set
            {
            if(value>0)
                {
                    _rollNumber = value;
                }
            else
                {
                    _rollNumber = 0;
                    Console.WriteLine("Roll Number cannot be negative");
                }
            }
        }

        public string name
        {
            get
            {
                return !string.IsNullOrEmpty(_name) ? _name : "NO Name Provided";
            }
            set
            {
                _name = value;
            }
        }

        public int Passmark
        {
            get
            {
                return _passmark;
            }
            // no set modifer
        }

        private string _city;
        public string city
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        public string Email { get; set; }

    }

}
