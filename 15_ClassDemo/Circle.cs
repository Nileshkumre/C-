using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ClassDemo
{
    internal class Circle
    {
        public int Radius; // instance member 
        public static float pi =3.14f;// static member
        public void Area() // instance member 
        {
            Console.WriteLine($"Area of circle ={pi * Radius * Radius}");

        }

    }
}
