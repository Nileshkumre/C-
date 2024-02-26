using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool b1 = true;
            Console.WriteLine(b1);
            Console.WriteLine(sizeof(bool));

            byte i1 = 10;
            Console.WriteLine(i1);
            Console.WriteLine(sizeof(byte));
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            short i2 = 10;
            Console.WriteLine($"{i2} : {sizeof(short)}: {short.MinValue}:{short.MaxValue}"  );

            int i4 = 10;
            Console.WriteLine($" {i4} : {sizeof(int)} : {int.MinValue} : {int.MaxValue}");
            
            long i3 = 10;
            Console.WriteLine($"{i3} : {sizeof(long)}: {long.MaxValue}: {long.MinValue}");

            float i5 = 10.5f;
            Console.WriteLine($"{i5} : {sizeof(float)} :{float.MaxValue} : {float.MinValue}");

            double i6 = 10.25d;
            Console.WriteLine($"{i5} : {sizeof(double)} :{double.MaxValue} : {double.MinValue}");

            decimal i7 = 105m;
            Console.WriteLine($"{i5} : {sizeof(decimal)} :{decimal.MaxValue} : {decimal.MinValue}");

            char div = '$';
            Console.WriteLine(div);
            Console.WriteLine(sizeof(char));

         

            Console.ReadLine();


        }
    }
}
