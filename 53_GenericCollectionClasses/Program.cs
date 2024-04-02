using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_GenericCollectionClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List<>

            //List<object> list = new List<object>() ;
            //List<int> numbers = new List<int>();
            //numbers.Add(1015);
            //numbers.Add(1016);
            //numbers.Add(1017);
            //numbers.Add(1018);
            //Console.WriteLine($"Number of Item : {numbers.Count}");
            //foreach(var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> temp = new List<int>();
            //numbers.AddRange(temp);
            //foreach(int item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n -----------------------------------------------------------");

            //numbers.Insert(1,15);
            //foreach (int item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n -----------------------------------------------------------");

            //bool b1=numbers.Contains(1015);
            //Console.WriteLine($"1015 Exist? : {b1}");
            //b1 = numbers.Contains(2);
            //Console.WriteLine($"2 Exist? : {b1}");

            //numbers.Remove(1015);
            //numbers.RemoveAt(0);
            //numbers.RemoveRange(2,1);
            //foreach (int item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n -----------------------------------------------------------");

            #endregion List<>

            #region Dictionary
            //Dictionary<int,string> student1=new Dictionary<int,string>();
            //student1.Add(1, "Nilesh");
            //student1.Add(2, "Mahi");
            //student1.Add(3,  "kunal");
            //student1.Add(4, "mayuri");

            //Console.WriteLine($"numbers of item {student1.Count}");
            ////foreach(var item in student1)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //foreach (KeyValuePair<int,string> item in student1)
            //{
            //    Console.WriteLine($"key : {item.Key} value : {item.Value}");
            //}

            //bool b1 = student1.ContainsKey(2);
            //Console.WriteLine($"2 Exits? : {b1}");

            //b1= student1.ContainsKey(3);
            //Console.WriteLine($"Exits? :{b1}");

            //string name = student1[2];
            //Console.WriteLine(name);





            #endregion Dictionary

            #region Stack
            //Stack<string> names=new Stack<string>();
            //names.Push("Nilesh");
            //names.Push("Mahhi");
            //names.Push("Rahual");

            //Console.WriteLine($"numbers of item :{names.Count}");
            //string name = names.Pop();
            //Console.WriteLine(name);
            //Console.WriteLine($"Number of item :{names.Count}");

            //name = names.Peek();
            //Console.WriteLine(name);
            //Console.WriteLine($"numbers of item :{names.Count}");

            //name = names.Peek();
            //Console.WriteLine(name);
            //Console.WriteLine($"numbers of item :{names.Count}");

            //name = names.Pop();
            //name = names.Peek();
            //Console.WriteLine(name);
            //Console.WriteLine($"numbers of item :{names.Count}");



            #endregion Stack 

            #region Queue<>

            Queue<string> name = new Queue<string>();
            name.Enqueue("Nilesh");
            name.Enqueue("mahi");
            name.Enqueue("rupesh");

            Console.WriteLine($"name of item : {name.Count}");

            string names=name.Dequeue();
            Console.WriteLine(name);
            Console.WriteLine($"numbers of item : {name.Count}");

            names = name.Peek();
            Console.WriteLine(names);
            Console.WriteLine($"number of item: {name.Count}");
            #endregion Queue<>

            Console.ReadLine();
        }
    }
}
