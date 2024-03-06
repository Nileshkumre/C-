using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    public class Customer
    {
        public int TicketAmount;
        public string Name = "customer";

        public Customer()
        {
            Console.WriteLine($" Customer() Constructor called");
        }
        public void ShowsTiming()
        {
            Console.WriteLine("** ALL TODAYS SHOWS **");
        }
        public void GetticketAmount()
        {
            Console.WriteLine($"Ticket Amount is : {TicketAmount}");
        }


    }
}
