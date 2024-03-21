using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _34_AbstractionEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// you can insert new student data 
            //Student s1 = new Student() { RollNumber = 1, Name = "Nilesh", Gender = "Male" };
            
            ////if(s1.Isvalid())
            ////{
            ////    s1.Insert(); //we can insert data
            ////}

            //Student s2 = new Student();
            //s2.Insert();

            //Student s3 =new Student();
            //s3.Insert();

            Student s1 =new Student(10,"nilesh","Male");
            s1.Insert();


            Console.ReadLine();

        }
    }

    public class Student
    {
        private int RollNumber;
        private string Name;
        private string Gender;

        public Student(int rn,string fn,string ln)
        {
            RollNumber = rn;
            Name = fn;
            Gender = ln;    
        }   

        private bool Isvalid()
        {
            if(RollNumber >0 && !string.IsNullOrEmpty(Name) &&
                    !string.IsNullOrEmpty(Gender)){
                return true;
            }
            else
            {
                return false;
            }

        }
        public void Insert()
        {
            if(Isvalid())
            {
                Console.WriteLine("New Student Inserted Succesfully");

            }
            else
            {
                Console.WriteLine("Invalid data to insert");
            }
            // code to insert data
        }
    }
}
