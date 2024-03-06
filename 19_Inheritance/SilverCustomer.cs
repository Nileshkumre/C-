using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    //Child class // derived class

    public class SilverCustomer : Customer
    {
        //public int TicketAmount;  //field
        //public string Name = "Silver customer";
        //public SilverCustomer()  // constructor
        //{
        //    Console.WriteLine($"SilverCustomer() Constructor called");
        //    //Console.WriteLine($"Name from current class : {this.Name}");
        //    //Console.WriteLine($"Name from base class : {base.Name}");
        //    TicketAmount = 200;
        //}

        public SilverCustomer(string name)
        {
            Console.WriteLine($"Inside SilverCustomer(string name) : {name}");
        }

        //public void ShowTiming()
        //{
        //    Console.WriteLine("** ALL  TODAYS SHOWS **");
        //}

        //public void GetTicketAmount()
        //{
        //    Console.WriteLine($"Ticket Amount is : {TicketAmount}");
        //}

        public void printTicket()
        {
            Console.WriteLine("Silver Ticket Printed");
        }



    }
}
