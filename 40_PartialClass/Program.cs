using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { Name = "Nilesh Kumre" };
            s1.AddEnquiry();
            
            Console.ReadLine();
        }
    }
}
