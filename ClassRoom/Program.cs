using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 3
            ClassRoom classRoom = new ClassRoom();
            classRoom.className = "3Q";
            classRoom.semesterStart = new DateTime(2019, 8, 26);
            classRoom.classList.Add(new Student("Vladimir", 15, 1));
            classRoom.classList.Add(new Student("Catalina", 8, 26));
            classRoom.classList.Add(new Student("Vladimir", 1, 1));
            classRoom.classList.Add(new Student("Razu", 12, 15));
            classRoom.classList.Add(new Student("Georgijs", 5, 19));

            //Task 4
            Console.WriteLine("Name of the class: " + classRoom.className);
            Console.WriteLine("Start of the semester: " + classRoom.semesterStart);
            foreach (var student in classRoom.classList)
            {
                Console.WriteLine($"Name: {student.name}");
            }

            classRoom.CountSeasonStudents();
                }
    }
}
