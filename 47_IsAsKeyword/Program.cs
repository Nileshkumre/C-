﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_IsAsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer c = new Customer();
            //c.Print();

            Customer c = new SilverCustomer();
            c.Print();

            Customer c2= new GoldCustomer();
            c2.Print();

            SilverCustomer c3 = (SilverCustomer)c;
            c3.Print();

            //GoldCustomer c4 = (GoldCustomer)c;
            //c4.Print();

            //bool b1 =c is GoldCustomer;
            //Console.WriteLine(b1);
            //if (b1)
            //{
            //    GoldCustomer c4 = (GoldCustomer)c;
            //    c4.Print();
            //}

            GoldCustomer c4=c as GoldCustomer; // if type cast is not possible it return is null 
            if (c4 != null)
            {
                c4.Print(); 
            }
           




            Console.ReadLine();
        }
    }

    public abstract class Customer
    {
        public abstract void Print();
    }

    public class SilverCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("SilverCustomer print() method");
        }
    }
    public class GoldCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("GoldCustomer print() method");
        }
    }



}
