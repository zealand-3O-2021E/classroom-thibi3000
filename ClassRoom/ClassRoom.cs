using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ClassRoom
    {
        private string className;
        private List<string> classList;
        private DateTime semesterStart;

        public ClassRoom()
        {
            className = "3o";
            classList = new List<string>();
            semesterStart = new DateTime(2021, 9, 2);
        }


    }


}
