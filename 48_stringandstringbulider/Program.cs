using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_stringandstringbulider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string intro = "my";
            //intro += "name";
            //intro += "is";
            //intro += "khan";
            //Console.WriteLine(intro);

            StringBuilder sb = new StringBuilder("hi");
            sb.Append("good ");
            sb.Append("morning");


            Console.WriteLine(sb.ToString());   

            Console.ReadLine();
        }
    }
}
