using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcultor c1 = new Calcultor();
            //bool b1 = c1.AreEqual(10, 10);
            //Console.WriteLine(b1);

            //b1 = c1.AreEqual(10, 2);
            //Console.WriteLine(b1);

            //b1 = c1.AreEqual("ABC","ABC");
            //Console.WriteLine(b1);

            //b1 = c1.AreEqual("10.5f", "2.5f");
            //Console.WriteLine(b1);

            //Calcultor c1 = new Calcultor();
            //bool b1 =c1.AreEqual<int>(10, 10);
            //Console.WriteLine(b1);

            //b1 = c1.AreEqual<string>("Nilesh", "Nilesh");
            //Console.WriteLine(b1);

            //b1 = c1.AreEqual<float>(10.5f, 10.5f);
            //Console.WriteLine(b1);

            //c1.Add<int>(10, 12);
            //c1.Add<string>("Nilesh", "kumre");
            //c1.Add<float>(10.5f, 10.5f);

            Student<int,string>s1 = new Student<int,string>();
            s1.RollNumber = 1;
            s1.Name = "Nilesh";
            s1.Details();

            Student<string,string>s2 = new Student<string,string>();
            s2.RollNumber ="2" ;
            s2.Name = "mahesh";
            s2.Details();



            Console.WriteLine(s1);




            Console.ReadLine();

        }
    }
}
