using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


/* Second Solution - With Class Student and Two List inside the class, we using as a key, our property Name for key
class Student
{
    public Student(string name)
    {
        Name = name;
        Dates = new List<DateTime>();
        Comments = new List<string>();
    }

    public string Name { get; set; }
    public List<DateTime> Dates {get; set;}
    public List<string> Comments { get; set; }


}


class Program
{

    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        string input;

        while ((input = Console.ReadLine()) != "end of dates")
        {

            var split = input.Split(' ', ',');

            var student = students.FirstOrDefault(s => s.Name == split[0]);

            if (student == null)
            {
                student = new Student(split[0]);
                students.Add(student);
            }

            student
                .Dates
                .AddRange(split.Skip(1).Select(d => DateTime.ParseExact(d, "dd/MM/yyyy", CultureInfo.InvariantCulture)));
        }

        while ((input = Console.ReadLine()) != "end of comments")
        {

            var split = input.Split('-');

            var student = students.FirstOrDefault(x => x.Name == split[0]);

            student?.Comments.Add(split[1]);

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
            foreach (var date in student.Dates.OrderBy(x => x))
            {
                Console.WriteLine($"-- {date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
}
*/
/* First Solution with Two Dictionaries - Not a good one! Too complicated */
namespace _8.MentorGroup
{
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
                string input;
            //START - ADDING STUDENTS WHO ATTENDED
                while ((input = Console.ReadLine()) != "end of dates")
                {
                var split = input.Split(' ', ',');

                string name = split[0];
                
                List<DateTime> parsedDates = new List<DateTime>();
                parsedDates = ParsedToListOfDates(split.Skip(1).ToArray());
                //parsedDates.AddRange(split.Skip(1).Select(d => DateTime.ParseExact(d, "dd/MM/yyyy", CultureInfo.InvariantCulture)));

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
                while ((input = Console.ReadLine()) != "end of comments")
                {

                    string[] split = input.Split('-');
                    string name = split[0];
                    string comment = split[1];

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

                    foreach (var date in student.DatesAttended.Values.OrderBy(x => x))
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
           
