using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_CollectionClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region array
            //int[]number =new int[2];
            //number[0]= 10;
            //number[1]= 20;

            //for(int i=0; i<number.Length;i++)
            //{
            //    Console.WriteLine(number[i]);   
            //}
            #endregion array

            #region Arraylist
            //Console.BackgroundColor = ConsoleColor.Red;
            //ArrayList numbers=new ArrayList(2);
            //numbers.Add(10);
            //numbers.Add(20);
            //numbers.Add(30);

            //Console.WriteLine("*** Orignal Collection ***");
            ////for(int i=0; i<numbers.Count;i++)
            ////{
            ////    Console.Write($"{numbers[i]} ");  
            ////}

            //foreach (int item in numbers) // Forward only 
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            //// add multiple item 
            //ICollection temp = new ArrayList() { 40, 50,60};
            //numbers.AddRange(temp);

            //Console.WriteLine("*** ddRange(temp) Collection ***");

            //foreach (var num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}
            //Console.WriteLine();

            ////10 20 30 40 50 60 
            ////numbers.Add(15);
            //numbers.Insert(1, 15);

            //Console.WriteLine("*** insert(1,15)  Collection ***");
            ////for (int i = 0; i < numbers.Count; i++)
            ////{
            ////    Console.Write($"{numbers[i]} ");
            ////}

            //foreach (object item in numbers)
            //{
            //    Console.Write($"{item}");
            //}
            //Console.WriteLine();

            //ICollection temp2 =new ArrayList() { 16, 17, 18 };


            //numbers.InsertRange(2, temp2);

            //Console.WriteLine("*** ddRange(temp) Collection ***");
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            //Console.WriteLine();

            //bool b1 =numbers.Contains(19);
            //Console.WriteLine($"19 :{b1}") ;

            //b1=numbers.Contains(20);
            //Console.WriteLine($"20 : {b1}");

            //numbers.Remove(20);
            //numbers.RemoveAt(1);


            //Console.WriteLine("*** Remove(15)  RemoveAt(0) ***");
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            //Console.WriteLine();

            //numbers.RemoveRange(0, 3);
            //Console.WriteLine("*** Remove(15)  RemoveAt(0) ***");
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            //Console.WriteLine();

            //numbers.Clear();// removes all items
            //Console.WriteLine($"number of item : {numbers.Count}");



            #endregion Arraylist

            #region Hashtable
            //Hashtable student = new Hashtable();
            //student.Add(1, "Nilesh");
            //student.Add(2, " Mahi");
            //student.Add(3, "ajay");
            //Console.WriteLine("*** All ITEM ***");
            ////for(int i =0;i<student.Count;i++)
            ////{
            ////    Console.Write($"{student.key[i]} value : {}");  
            ////}
            //foreach(DictionaryEntry item in student)
            //{
            //    Console.WriteLine($"key : {item.Key} value : {item.Value}");
            //}

            //bool b2 = student.ContainsKey(4);
            //Console.WriteLine($"4 key : {b2}");

            //b2 = student.ContainsValue("Nilesh");
            //Console.WriteLine($"Nilesh value :{b2}");
            //Console.WriteLine();

            //var val = student[2];
            //Console.WriteLine($"2 : {val}");

            #endregion Hashtable

            #region Stack
            Console.BackgroundColor = ConsoleColor.Red;

            //Stack visitedsites = new Stack();

            //visitedsites.Push("Google.com");
            //visitedsites.Push("facebook.com");
            //visitedsites.Push("facebook.com/friedns");
            //visitedsites.Push("facebook.com/users/Nilesh");

            //Console.WriteLine($"Number of item : {visitedsites.Count}");
            //var site=visitedsites.Pop(); // last added item
            //Console.WriteLine($"Returned :{site} Number of Item {visitedsites.Count}");

            //site=visitedsites.Pop();
            //Console.WriteLine($"Returned : {site} Number of Item {visitedsites.Count}");

            //site = visitedsites.Peek();

            //Console.WriteLine($"Returned : {site} Number of Item {visitedsites.Count}");


            #endregion Stack

            #region Queue

            //Queue bankToken = new Queue();
            //bankToken.Enqueue("mahi");
            //bankToken.Enqueue("Nilesh");
            //bankToken.Enqueue("Abhi");
            //bankToken.Enqueue("Rahual");

            //Console.WriteLine($"Number of item : {bankToken.Count}");
            //foreach (var item in bankToken)
            //{
            //    Console.WriteLine($"{item}");
            //}


            //var token = bankToken.Dequeue();
            //Console.WriteLine($"Deququq() : {token}");
            //Console.WriteLine($"No Item: {bankToken.Count}");

            //token = bankToken.Peek();
            //Console.WriteLine($"Peek () : {token}");
            //Console.WriteLine($"No Item: {bankToken.Count}");


            #endregion region Queue



            Console.ReadLine();
        }
    }
}
