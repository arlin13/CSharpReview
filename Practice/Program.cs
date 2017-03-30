using Practice.Models;
using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Santiago = new Student("Santiago");

            Student Erin = new Student("Erin", 15);
            Student Sabrina = new Student("Sabrina");
            Student Pamela = new Student("Pamela", 25);

            //Pamela.PrintStudentName();
            //Console.WriteLine(Pamela.ReturnAge(25));
            //Pamela.ReturnAge();

            ////Functions f = new Functions();
            ////Functions f3 = new Functions();
            ////Functions f3 = new Functions();

            ////Console.WriteLine(f.Add(1, 2));

            //Console.WriteLine(Functions.Multiply(10, 10));


            //Student Anthony = new Student(19);
            //Console.WriteLine(Anthony.Age);
            //Anthony.Age = 20;
            //Console.WriteLine(Anthony.Age);

            //Pamela.PrintStudentName();


            Console.Read();
        }

    }
}
