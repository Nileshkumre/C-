using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 10;
            Console.WriteLine(i);

            i = 20;
            Console.WriteLine(i);

            int a = i + j;
            Console.WriteLine(a);

            int s = i - j;
            Console.WriteLine(s);

            int m = i * j;
            Console.WriteLine(m);

            int d = i / j;
            Console.WriteLine(d);

            int mo = i % j;
            Console.WriteLine(mo);

            int ma = 5 % 2;
            Console.WriteLine(ma);

            i = i + 1;
            Console.WriteLine(i);

            Console.WriteLine(i++);
            Console.WriteLine(i);
            // console.writeline(i++);// post increment
            Console.WriteLine(++i);// pre increment//

            //i = i + 5;
            i += 5;/// 28 output
            Console.WriteLine(i);

            i -= 5;
            Console.WriteLine(i);

            i *= 5;
            Console.WriteLine(i);

            i /= 5;
            Console.WriteLine(i);

            bool result = i == j;
            Console.WriteLine(result);

            //result i!= j;
            //Console.WriteLine(result);

            result = i < j;
            Console.WriteLine(result);

            i++;
            result = i > j;
            Console.WriteLine(result);

      



            Console.ReadLine(); // to wait
        }
    }
}
