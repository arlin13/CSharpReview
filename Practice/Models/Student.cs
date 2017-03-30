using System;

namespace Practice.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private string SchoolName { get; set; }
        public DateTime DateOfBirth { get; set; }


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
