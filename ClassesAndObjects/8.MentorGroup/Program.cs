using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _8.MentorGroup
{
    class Student
    {
        public Student(string name)
        {
            Name = name;
            DatesAttended = new List<DateTime>();
            Comments = new List<string>();
        }

        public string Name { get; set; }
        public List<DateTime> DatesAttended {get; set;}
        public List<string> Comments { get; set; }
        

    }


    class Program
    {
        static List<DateTime> ParsedToListOfDates(string[] dates)
        {

            List<DateTime> parsedDates = new List<DateTime>(); 
            foreach (var date in dates)
            {
                parsedDates.Add(DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture));
            }
            return parsedDates;
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();
                string[] inputDates = line.Split();
                string name = inputDates[0];

                if (line == "end of dates")
                {
                    break;
                }

                string[] dates = inputDates[1].Split(',');
                List<DateTime> parsedDates = ParsedToListOfDates(dates);

                Student student = students.FirstOrDefault(x => x.Name == name);

                if (student == null)
                {
                    student = new Student(name);
                    students.Add(student);
                }

                student.DatesAttended.AddRange(parsedDates);
            }

            while (true)
            {
                string line = Console.ReadLine();
                string[] inputComments = line.Split('-');
                string name = inputComments[0];

                if (line == "end of comments")
                {
                    break;
                }
                string comment = inputComments[1];

                Student student = students.FirstOrDefault(x => x.Name == name);

                student?.Comments.Add(comment);

            }

            foreach (var student in students.OrderBy(s => s.Name))
            {

                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in student.DatesAttended.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
                }

            }
        }
    }
}
            /* First Solution with Two Dictionaries - Not a good one! Too complicated
             * 
            class Student
            {
                public string Name;
                public Dictionary<string, List<DateTime>> DatesAttended { get; set; }
                public Dictionary<string, List<string>> Comments { get; set; }

                public Student()
                {
                    DatesAttended = new Dictionary<string, List<DateTime>>();
                    Comments = new Dictionary<string, List<string>>();
                }
            }
            class Program
            {
                static List<DateTime> ParsedToListOfDates(string[] dates)
                {

                    List<DateTime> parsedDates = new List<DateTime>();
                    foreach (var date in dates)
                    {
                        parsedDates.Add(DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                    return parsedDates;
                }

                static void Main(string[] args)
                {

                    List<Student> students = new List<Student>(); 

                    //START - ADDING STUDENTS WHO ATTENDED
                    while (true)
                    {
                        string line = Console.ReadLine();
                        string[] inputDates = line.Split();
                        string name = inputDates[0];

                        if (line == "end of dates")
                        {
                            break;
                        }
                        string[] dates = inputDates[1].Split(',');
                        List<DateTime> parsedDates = ParsedToListOfDates(dates);

                        Student currentStudent = new Student();
                        currentStudent.Name = name;

                        bool isExist = false;

                        foreach (var student in students)
                        {
                            if (student.Name == name)
                            {
                                isExist = true;
                                if (student.DatesAttended.ContainsKey(name) == false)
                                {

                                    student.DatesAttended[name] = parsedDates;
                                }

                                else
                                {
                                    student.DatesAttended[name].AddRange(parsedDates);
                                }
                            }
                        }
                        if (isExist == false)
                        {
                            if (currentStudent.DatesAttended.ContainsKey(name) == false)
                            {
                                currentStudent.DatesAttended[name] = new List<DateTime>();
                                currentStudent.DatesAttended[name] = parsedDates;

                            }
                            else
                            {
                                currentStudent.DatesAttended[name].AddRange(parsedDates);
                            }
                            students.Add(currentStudent);
                        }

                    }
                    //END - ADDING STUDENTS WHO ATTENDED

                    //START - ADDING THE COOMENTS INTO THE DICTIONARIES, ONLY TO STUDENTS WHO HAS ATTENDED DATES
                    while (true)
                    {
                        string line = Console.ReadLine();
                        string[] inputComments = line.Split('-');
                        string name = inputComments[0];

                        if (line == "end of comments")
                        {
                            break;
                        }
                        string comment = inputComments[1];

                        Student currentStudent = new Student();
                        currentStudent.Name = name;


                        bool isExist = false;

                        //if student exist add the new comments to the student
                        foreach (var student in students)
                        {
                            if (student.Name == name)
                            {

                                //student.DatesAttendedn = {"name", [22/14/34, 12, 11, 44]}
                                //student.Comments = {"name", ["Some comment", "Second comment"]}

                                if (student.DatesAttended[name].Count == 0)
                                {
                                    break;
                                }

                                else
                                {
                                    isExist = true;
                                    if (student.Comments.ContainsKey(name) == false)
                                    {
                                        student.Comments[name] = new List<string>();
                                        student.Comments[name].Add(comment);
                                    }
                                    else
                                    {
                                        student.Comments[name].Add(comment);

                                    }

                                }
                            }
                        }
                    }
                    //END - ADDING THE COOMENTS INTO THE DICTIONARIES, ONLY TO STUDENTS WHO HAS ATTENDED DATES

                    //PRINT THE RESULT IN List<Students>

                    //students = [ {student1 : { name1 : { dateAttended: [date1, date2]}, {comments: [comment1, commen2]} }, {student2: ..} ]
                    foreach (var student in students.OrderBy(x => x.Name))
                    {
                        Console.WriteLine(student.Name);
                        Console.WriteLine("Comments:");
                        //print comments
                        foreach (var comment in student.Comments.Values)
                        {
                            foreach (var item in comment)
                            {
                                Console.WriteLine($"- {item}");
                            }
                        }
                        //print dates attended:
                        Console.WriteLine("Dates attended:");

                        foreach (var date in student.DatesAttended.Values)
                        {
                            foreach (var item in date.OrderBy(x => x))
                            {
                                Console.WriteLine($"-- {item.ToString("dd/MM/yyyy")}");

                            }
                        }
                    }

                }
            }
        }
            */
