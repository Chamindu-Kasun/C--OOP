using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.SetName("John");
        person.SayHello();

        Student student = new Student();
        student.SetName("Alice");
        student.Grade = "A";
        student.SayHello();
        student.ShowGrade();
    }
}
