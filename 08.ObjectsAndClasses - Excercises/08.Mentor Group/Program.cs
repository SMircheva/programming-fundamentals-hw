using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _08.Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> mentorGroup = new List<Student>();

            //check if the students already exists!
            while (input != "end of dates")
            {
                var inputList = input.Split(new char[] { ',', ' ' }).ToList();

                if (!mentorGroup.Any(x => x.Name == inputList[0]))
                {
                    Student currentStudent = new Student();
                    currentStudent.Name = inputList[0];
                    currentStudent.Attendences = new List<DateTime>();
                    currentStudent.Comments = new List<string>();
                    inputList = inputList.Skip(1).ToList();
                    List<DateTime> datesList = inputList.Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
                    currentStudent.Attendences.AddRange(datesList);
                    mentorGroup.Add(currentStudent);
                }
                else
                {
                    var name = inputList[0];
                    inputList = inputList.Skip(1).ToList();
                    List<DateTime> datesList = inputList.Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
                    for (int i = 0; i < mentorGroup.Count; i++)
                    {
                        if (mentorGroup[i].Name == name)
                        {
                            mentorGroup[i].Attendences.AddRange(datesList);
                        }
                    }
                }              
                
                
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "end of comments")
            {
                var inputArray = input.Split('-');
                var studentName = inputArray[0];
                var comment = inputArray[1];
                foreach (var student in mentorGroup)
                {
                    if (student.Name == studentName)
                    {
                        student.Comments.Add(comment);
                        break;
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var student in mentorGroup.OrderBy(x => x.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Attendences.OrderBy(x => x.Date))
                {
                    Console.WriteLine("-- " + date.ToString(@"dd\/MM\/yyyy"));
                }

            }
        }

        class Student
        {
            public string Name { get; set; }
            public List<DateTime> Attendences { get; set; }
            public List<string> Comments { get; set; }
        }
    }
}
