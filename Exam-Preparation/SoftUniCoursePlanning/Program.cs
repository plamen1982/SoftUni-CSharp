using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            List<string> lessons = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            List<string> lessonsToRemove = new List<string>();

            while ((line = Console.ReadLine()) != "course start")
            {
                string[] tokens = line.Split(':', StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                string command = tokens[0];
                string lesson = tokens[1];

                if (command == "Insert")
                {
                    if (lessons.Contains(lesson) == false)
                    {
                        int index = int.Parse(tokens[2]);
                        lessons.Insert(index, lesson);
                    }

                }
                else if (command == "Remove")
                {
                    if (lessons.Contains(lesson) == true)
                    {
                        lessons.Remove(lesson);
                        lessonsToRemove.Add(lesson);
                    }
                }

                else if (command == "Add")
                {
                    if (lessons.Contains(lesson) == false)
                    {
                        lessons.Add(lesson);
                    }
                }
                else if (command == "Swap")
                {   //Database
                    string lessonToSwap = tokens[2];
                    //list                                          //Database
                    if (lessons.Contains(lesson) && lessons.Contains(lessonToSwap))
                    {
                        if (lessons.Contains(lessonToSwap + "-Exercise"))
                        {
                            //1
                            int indexNewLesson = lessons.IndexOf(lesson);
                            //3
                            int indexOldLesson = lessons.IndexOf(lessonToSwap);
                            //4
                            int indexOfExersize = lessons.IndexOf(lessonToSwap + "-Exercise");

                            lessons.Insert(indexNewLesson, (lessonToSwap + "-Exercise"));
                            lessons.Insert(indexNewLesson, lessonToSwap);

                            lessons.RemoveAt(indexOldLesson + 3);
                            lessons.RemoveAt(indexOldLesson + 2);

                            lessons.Insert(indexOldLesson + 1, lesson);
                            lessons.Insert(indexOldLesson, lessons[indexOldLesson + 2]);

                            lessons.RemoveAt(indexOldLesson + 2);
                            lessons.RemoveAt(indexOldLesson + 2);

                            //Methods 0 
                            //Datavases 1
                            //Datavases-Ex 2
                            //List 3
                            //Methods 4
                            //Datavases - detelted 5
                            //Datavases-Ex 6 -> 5 -deleted

                            //1.Arrays
                            //2.Methods
                            //3.Lists
                            //4.Databases
                            //5.Lists
                            //6.Methods

                            //1.Methods
                            //2.Databases
                            //3.Databases - Exercise
                            //4.Arrays
                            //5.Lists


                        }
                        else
                        {
                            int indexNewLesson = lessons.IndexOf(lesson);
                            int indexOldLesson = lessons.IndexOf(lessonToSwap);

                            lessons.Insert(indexNewLesson, lessonToSwap);
                            lessons.RemoveAt(indexNewLesson + 1);

                            lessons.Insert(indexOldLesson, lesson);
                            lessons.RemoveAt(indexOldLesson + 1);
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    if (lessons.Contains(lesson) == false)
                    {
                        lessons.Add(lesson);
                        lessons.Add(lesson + "-Exercise");
                    }
                    else
                    {
                        lessons.Add(lesson + "-Exercise");
                    }
                }
            }

            foreach (var item in lessons)
            {
                foreach (var item1 in lessonsToRemove)
                {
                    if(item.Contains(item1))
                    {
                        lessons.Remove(item1);
                    }
                }
            }
            int count = 1;
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{count}.{lessons[i]}");
                count++;
            }
        }
    }
}
