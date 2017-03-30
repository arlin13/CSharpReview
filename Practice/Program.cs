using Practice.Math;
using Practice.Models;
using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objects of the Student class, calling different constructors
            Student Santiago = new Student("Santiago");
            Student Erin = new Student("Erin", 15);
            Student Sabrina = new Student("Sabrina");
            Student Pamela = new Student("Pamela", 25);

            // Calling methods from the Student class - Pamela object
            Pamela.PrintStudentName();
            Console.WriteLine(Pamela.ReturnAge(25));
            Pamela.ReturnAge();

            // Creating another object and editing the property values later
            Student Anthony = new Student("Anthony", 19);
            Console.WriteLine(Anthony.Age);
            Anthony.Age = 20;
            Console.WriteLine(Anthony.Age);

            Pamela.PrintStudentName();


            ///////////////////////////////////////////


            // You cant do this because the 'Function' class is STATIC 
            // That is why you can instantiate the class
            //Functions f = new Functions();
            //Functions f3 = new Functions();
            //Functions f3 = new Functions();

            //Console.WriteLine(f.Add(1, 2));


            // Since the class 'Function' is STATIC, all that you have to do is write the name of the class (and the using statement if that class is in another namespace)
            Console.WriteLine(Functions.Multiply(10, 10));


            Console.Read();
        }

    }
}
