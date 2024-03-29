using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _50_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Early binding 
            //Customer c = new Customer();
            //c.PrintA();

            //Late binding and Reflection 
            //mthod--> class object --> class --> namespace --> assembly
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type Customer = assembly.GetType("_50_Reflection.Customer");
           
            if(Customer != null)
            {
                
                object c = Activator.CreateInstance(Customer);
                
                if(c != null)
                {
                    MethodInfo PrintA = Customer.GetMethod("PrintA");
                    
                    if(PrintA != null)
                    {
                        PrintA.Invoke(c, null);
                    }
                    MethodInfo PrintC=Customer.GetMethod("PrintC");
                    PrintC.Invoke(c, new object[] { "NIlesh", "KUmre" });
                    
                }      
                MethodInfo PrintB = Customer.GetMethod("PrintB");
                PrintB.Invoke(null, null);

                MethodInfo PrintD = Customer.GetMethod("PrintD", BindingFlags.NonPublic | BindingFlags.Instance);

                PrintD.Invoke(c,null);
            }

            //All Method
            Console.WriteLine("*** All Method ***");
            MethodInfo[] methods=Customer.GetMethods();
            for(int i= 0;i<methods.Length; i++)
            {
                Console.WriteLine(methods[i].Name);
            }

            //All properties
            Console.WriteLine("*** All Properties ***");
            PropertyInfo[] properties=Customer.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                Console.WriteLine($"{properties[i].Name} " + $"{properties[i].PropertyType}");
            }

            Console.ReadLine();
        }

    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }    
        public void PrintA()
        {
            Console.WriteLine("PrintA() Method Called");
        }

        public static void PrintB()
        {
            Console.WriteLine("static PrintB() Method Called");
        }

        public void PrintC(string Firstname,string Lastname)
        {
            Console.WriteLine($"PrintC() Method Called{Firstname} {Lastname}");
        }

         private void PrintD()
        {
            Console.WriteLine("private PrintD() Method Called");
        }
    }


}
