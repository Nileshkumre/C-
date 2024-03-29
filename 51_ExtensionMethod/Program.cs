using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _51_ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string type
            //int i = 10;
            //string name = "nilesh";
            //string r1 =name.ToUpper();
            //Console.WriteLine(r1);

            //r1 = name.ToCaptitalCase(); // Capital case 
            //Console.WriteLine(r1);

            //string s = "vhasssh";
            //r1 = s.ToCaptitalCase();
            //Console.WriteLine(r1);

            #endregion string type

            BMW o1 =new BMW();
            o1.Print("A");

            AUDI o2 = new AUDI();
            o2.Print("B");

            
            
             

            Console.ReadLine();

        }
    }

    public static class Stringhelper
    {
        public static string ToCaptitalCase(this string name)
        {
            string result = string.Empty;
            for(int i=0; i<name.Length; i++)
            {
                if(i==0)
                {
                    result += name[i].ToString().ToUpper();

                }
                else
                {
                    result += name[i];
                }
            }
            return result;
        }
    }

    public interface Icar { }

    public class BMW: Icar
    {
        public int id { get; set; }
        public static void PrintA()
        {
            //Console.WriteLine(id);
        }
        public void PrintB()
        {
            Console.WriteLine(this.id);
        }


        //public void Print()
        //{
        //    Console.WriteLine($"print() : {GetType().Name}");
        //}
    }

    public class AUDI : Icar
    {
       
        //public void Print()
        //{
        //    Console.WriteLine($"print() : {GetType().Name}");
        //}
    }

    public static class CarHelper
    {
        public static void Print(this Icar o,string S)
        {
            Console.WriteLine($"print(): {S}: {o.GetType().Name}");
        }
        
    }
}
