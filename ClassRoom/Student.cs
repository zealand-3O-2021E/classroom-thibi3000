using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        private string name;
        private int birthMonth;
        private int birthday;

        public Student(string name, int birthMonth, int birthday)
        {
            this.name = name;
            this.birthMonth = birthMonth;
            this.birthday = birthday;
        }
    }
}
