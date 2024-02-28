using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _6_NullableType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Nilesh";
            Console.WriteLine(name);

            name = null;
            Console.WriteLine(name);

            int? age = null;/// non-nullable
            bool? isdeliverd = null; /// non nullable
            DateTime? dob = null; /// non nullable

            Nullable<int> marks = null;

            // int? = all int types values+ null values

            int? a = 10;
            int b = (int)a; //int?=> int
            Console.WriteLine($" a : {a} b : {b}");

            //int a = null;
            //int b = a ?? 0;
            // Console.WriteLine($" a :{a} b : {b}");


            //string email = "nileshkumre56@gmail.com";
           string email = null;
            string emailinupper = email?.ToUpper();
            Console.WriteLine($" email: {email} \n email in upper {emailinupper}");


            Console.ReadLine();

            
        }
    }
}
