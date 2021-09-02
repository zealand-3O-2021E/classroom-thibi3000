using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ClassRoom
    {
        public string className;
        public List<Student> classList;
        public DateTime semesterStart;

        public ClassRoom()
        {
            classList = new List<Student>();
            semesterStart = new DateTime();
        }

        public void CountSeasonStudents()
        {
            //vier lijsten maken(elk seizoen)
            List<Student> Summer = new List<Student>();
            List<Student> Spring = new List<Student>();
            List<Student> Winter = new List<Student>();
            List<Student> Autumn = new List<Student>();

            //leerlingen toevoegen
            foreach (var student in classList)
            {
                if (student.birthMonth == 1 || student.birthMonth == 2 || student.birthMonth == 12)
                {
                    Winter.Add(student);
                }
                else if(student.birthMonth >= 3 && student.birthMonth <= 5)
                {
                    Spring.Add(student);
                }
                else if(student.birthMonth >=6 && student.birthMonth <= 8)
                {
                    Summer.Add(student);
                }
                else if(student.birthMonth >= 9 && student.birthMonth <= 11)
                {
                    Autumn.Add(student);
                }
            }
            //records tellen
            Console.WriteLine($"Winter:  {Winter.Count}");
            Console.WriteLine($"Spring:  {Spring.Count}");
            Console.WriteLine($"Summer:  {Summer.Count}");
            Console.WriteLine($"Autumn:  {Autumn.Count}");
        }
    }


}
