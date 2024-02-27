using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_StringType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "nilesh";

            Console.WriteLine(name);
            Console.WriteLine(name.Length);

            name = "     Nilesh";
            Console.WriteLine(name);

            Console.WriteLine(name.Trim());

            name = "nilesh    ";
            Console.WriteLine(name.TrimEnd());

            name = "Nilesh";
            Console.WriteLine(name.ToUpper());

            name = "Nilesh";
            Console.WriteLine(name.ToLower());

            name = "\"Nilesh\"";
            Console.WriteLine(name);

            name = "\\Nilesh\\";
            Console.WriteLine(name);

            Console.WriteLine("Nilesh kumre");
            Console.WriteLine("nilesh\t kumre");
            Console.WriteLine("nilesh\nkumre");

            string path = "C:\\git\\B22CSharpDemos\\3_Operators";  
            Console.WriteLine(path);

            string firstname = "nilesh";
            string lastname = "kumre";
            string fullname = firstname + "  " + lastname;
            Console.WriteLine(fullname);

            fullname = firstname + "  " + lastname;
            Console.WriteLine(fullname);

            fullname = string.Concat(firstname, " ", lastname);
            Console.WriteLine(fullname);

            string middlename = "Suresh";
            fullname = string.Concat(firstname + "  " + middlename + " ", lastname);
            Console.WriteLine(fullname);


            fullname = string.Join(" ", firstname, middlename, lastname);
            Console.WriteLine(fullname);

            fullname = string.Join(" ", "full", "name", ":", firstname, middlename, lastname);
            Console.WriteLine(fullname);

            fullname = string.Format("full name : {0} {1} {2} ", firstname, middlename, lastname);

            Console.WriteLine(fullname);

            // string interpolation///

            fullname = $"full name : {firstname} {middlename} {lastname}";
            Console.WriteLine(fullname);

            fullname = $"my father name is : {middlename}";
            Console.WriteLine(fullname);












            Console.ReadLine();

        }
    }
}
