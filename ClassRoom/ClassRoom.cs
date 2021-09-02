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


    }


}
