using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
    class Student : Human
    {
        public int Grade { get; set; }
        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }
    }
}
