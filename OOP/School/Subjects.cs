using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Subjects
    {
        public string NameSubject { get; set; }
        public int NumberOfHours { get; set; }
        public int NumberOfExersices { get; set; }

        public Subjects(string nameSubject, int numberOfHourse, int numberOfExersices)
        {
            this.NameSubject = nameSubject;
            this.NumberOfHours = NumberOfHours;
            this.NumberOfExersices = NumberOfExersices;
        }
    }
}
