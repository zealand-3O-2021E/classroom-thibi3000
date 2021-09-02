using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        public string name;
        public int birthMonth;
        private int birthday;

        public Student(string name, int birthMonth, int birthday)
        {
            this.name = name;           
            if (birthMonth >= 1 && birthMonth <= 12)
            {
                this.birthMonth = birthMonth;

            }          
            this.birthday = birthday;
        }

        public string season()
        {
            switch(birthMonth)
            {
                case 3:
                case 4:
                case 5:
                    return "Spring";
    
                case 6:
                case 7:
                case 8:
                    return "Summer";
                    
                case 9:
                case 10:
                case 11:
                    return "Autumn";

                case 12:
                case 1:
                case 2:
                    return "Winter";

                default:
                    return "The given month is not between 1 and 12!!";

            }
        }
    }
}
