using System;
using System.Collections.Generic;
using System.Text;

namespace firstConsoleApp
{
    class Student
    {
        public string name;
        public int age;
        public int[] grades;

        public Student(string n, int a, int[] g)
        {
            name = n;
            age = a;
            grades = g;
        }

        public decimal CalculateGPA()
        {
            decimal sum = 0;
            foreach (int grade in grades)
            {
                sum = grade;
            }

            return (sum / (grades.Length)) / 25;
        }
    }
}
