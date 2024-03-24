// Mahi classs 
// properties
public  partial class Student
    :IStudent
{ 
    public string Name { get; set; }

    public Student()
    {
        PrintA();
    }
    partial void PrintA(); //parital method 

   
} 
interface IStudent
{
    void Print();
}
public class A { }
public class B { }