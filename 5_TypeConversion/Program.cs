using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 10,j = 10;
            Console.WriteLine(i + j);

            string a = i.ToString();
            string b = j.ToString();
            Console.WriteLine(a + b);

            byte b1 = 10;
            short s1 = b1; // byte => short

            Console.WriteLine(s1); //10

            float f1 = s1;
            Console.WriteLine(f1);  // 10

            int i1 = (int)f1; ///float=> int
            Console.WriteLine(i1);

            f1 = 25.55f;
            i1 = (int)f1;
            Console.WriteLine(i1);   //25 loss of data 55 

            string s = "100";
            //i1 = (int)s;
            i1 = Convert.ToInt32(s);
            Console.WriteLine(i1);

            s= "True";
            bool bb = Convert.ToBoolean(s);
            Console.WriteLine(bb);

            s = "777";
            i1 = int.Parse(s);
            Console.WriteLine(i1);

            s = "2000";
            bb=int.TryParse(s,out i1);
            Console.WriteLine($"status : {bb} result : {i1}");

            s = "xyz";
            bb=int.TryParse(s.ToString(),out i1);
            Console.WriteLine($"status : {bb} result : {i1}");






























            Console.ReadLine();


        }
    }
}
