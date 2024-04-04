 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7_Assingment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your name:");
            string name=Console.ReadLine();
            string reversename="";
            for (int i= name.Length - 1; i>=0;i--)    
            {
                reversename+= name[i];
            }
            Console.WriteLine(reversename);
            Console.ReadLine();
        }
    }
}
