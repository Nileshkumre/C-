using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _42_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.RollNumber = 1;
            s1.Name = "Nilesh";
            //s1.Gender = "Male"; 
            //s1.Gender = 1;
            s1.Gender = EGender.Male;
            s1.subject = Subject.Mathematics;

            // Console.WriteLine($"Roll Number : {s1.RollNumber} Name : {s1.Name} Gender : {GetGender(s1.Gender)}");
            Console.WriteLine($"Roll Number : {s1.RollNumber} Name : {s1.Name} Gender : {s1.Gender}");

            Student s2 = new Student();
            s2.RollNumber = 2;
            s2.Name = "Mahi";
            //s2.Gender = "Female";
            //s2.Gender = 2;
            s2.Gender = EGender.Female;
            s2.subject = Subject.Mathematics;

            Console.WriteLine($"Roll Number : {s2.RollNumber} Name : {s2.Name} Gender : {s2.Gender}");

            Student s3 = new Student();
            s3.RollNumber = 3;
            s3.Name = "sony";
            s3.Gender = EGender.Female;
            s3.subject = Subject.Mathematics;

            Console.WriteLine($"Roll Number : {s3.RollNumber} Name : {s3.Name} Gender : {s3.Gender}");
            
            Console.WriteLine("All items in enum");
            string[] names=Enum.GetNames(typeof(EGender));
            for(int i =0; i<names.Length; i++) 
            {
                Console.Write($"{names[i]}\t");
            }
            Console.WriteLine();

            Console.ReadLine();
        }


        //after writting enum this is not usefull
        //
        static string GetGender(int gender)
        {
            switch (gender)
            {
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid Gender";
            }

        }
    }

     
}
