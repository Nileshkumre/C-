using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    internal class Program
    {
        static void Main()
        {

            int price = 0;
            decimal smallcoffe = 150;
            decimal mediumcoffe = 200;
            decimal largecoffe = 300;
           


            int TotalPrice = 0;
            bool b = true;

            while (b)
            {

                Console.WriteLine("Welcome to coffee shop choose coffe : 1. small 2 .medium 3.Large");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {

                    case 1:
                        Console.WriteLine("Small coffe");
                        price = 150;
                        Console.Write("Enter the quantity for small coffe: ");
                        int small1 = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("medium coffe");
                        price = 200;
                        Console.Write("Enter the quantity for medium coffe: ");
                        int mediumquantity = int.Parse(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Large Coffe");
                        price = 350;
                        Console.Write("Enter the quantity for Large coffe: ");
                        int largequantity = int.Parse(Console.ReadLine());
                        break;


                    default:
                        Console.WriteLine("Invalid choice");
                        return;

                }
              





                Console.WriteLine($"Toata price {price}");

                Console.WriteLine("Would you want anything else (Y/N)");
                string s = Console.ReadLine();
                s = s.ToUpper();

                if (s == "Y")
                {
                    b = true;
                }
                else 
                {
                    b = false;
                }
            }
           
          
                Console.WriteLine("Thank You For Visiting....");

                Console.ReadLine();
            
        }
    }
    
    
}


