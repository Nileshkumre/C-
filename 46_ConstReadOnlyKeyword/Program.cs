using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_ConstReadOnlyKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1= new Student();
            s1.RollNumber = 1;
            s1.Name = "Nilesh";
           // s1.CompanyName = "V#";
            Console.WriteLine($"RollNumber : {s1.RollNumber} Name : {s1.Name} Conampny name : {s1.CompanyName}");
            Student s2= new Student();
            s2.RollNumber = 2;
            s2.Name = "Mahi";
            //s2.CompanyName = "V#";
            
            

            Console.WriteLine($"RollNumber : {s2.RollNumber} Name : {s2.Name} Conampny name : {s2.CompanyName}");
         

            Console.ReadLine();
        }
    }
    public class Student
    {
        public int RollNumber {  get; set; }    
        public string Name { get; set; }
        // public static string CompanyName = "V#";
        //public const string CompanyName = "V#";
        public  readonly string CompanyName;    
        public Student()
        {
            CompanyName = "V#";
        }
    }
}
