using System;

namespace Practice.Models
{
    public class Student
    {
        //PROPERTIES
        //caracteristics of the object. In this case, the students have a name, lastname, age, etc...
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private string SchoolName { get; set; }
        public DateTime DateOfBirth { get; set; }

        //CONSTRUCTORS
        //if you create a class without a constructor, it will automatically have a constructor without parameters. In this case it would be something like:
        //Ex. public Student(){}
        public Student(string name)
        {
            Name = name;
            SchoolName = "Origin Code Academy";
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            SchoolName = "Origin Code Academy";
        }
        public Student(string name, string LastName, int age)
        {
            Name = name;
            this.LastName = LastName;
            Age = age;
            SchoolName = "Origin Code Academy";
        }

        //METHODS
        //Actions of the object (Student)
        public void PrintStudentName() {
            Console.WriteLine("The student name is: " + this.Name);
        }

        public int ReturnAge() {
            Console.WriteLine("Return Age method");
            return this.Age;
        }
        public int ReturnAge(int age) {
            return age;
        }
    }
}
