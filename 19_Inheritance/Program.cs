using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SilverCustomer sc1 = new SilverCustomer();
            //sc1.ShowsTiming();
            //sc1.GetticketAmount();  
            //sc1.printTicket();

            //GoldCustomer sc2 = new GoldCustomer();
            //sc2.ShowsTiming();
            //sc2.GetticketAmount();
            //sc2.PrintTicket();

            //PlatinumCustomer sc3 = new PlatinumCustomer();
            //sc3.ShowsTiming();
            //sc3.printTicket();
            //sc3.GetticketAmount();

            //// if we have parent & child class
            //Customer C1 = new Customer();
            //// C1 is reference variable of type customer pointing customer type

            //SilverCustomer C2 = new SilverCustomer();
            //// C2 is reference variable of type customer pointing to silvercustomer type

            //Customer C3 = new SilverCustomer();
            ////C3 is reference variable of type customer pointing to silvercustomer

            ////SilverCustomer S2 = new Customer(); // complie error

            //SilverCustomer s3 = (SilverCustomer)new Customer(); //runtime error 
            

            //Customer C1 = new Customer();
            Customer c2 = new SilverCustomer("nilesh"); 
            


            Console.ReadLine();
        }
    }
}
