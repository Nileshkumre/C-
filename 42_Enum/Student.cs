using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Enum
{
    internal class Student
    {
        public int RollNumber { get; set; } 
        public string Name { get; set; }    
        //public string Gender { get; set; }  
       // public int Gender { get; set; } 
       public EGender Gender { get; set; }
        public Subject subject {  get; set; }
    }
    public enum EGender
    {
        Male,Female,unknow
    }

    public enum Subject
    {
        marathi,
        Hindi,
        English,
        Mathematics,
        Chemistry,
        Physics 

    }
}
