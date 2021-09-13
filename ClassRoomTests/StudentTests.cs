using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        public void StudentTest()
        {
            Assert.Fail();
        }

        [DataTestMethod()]
        [DataRow("Thibo", 3, 18)]
        [DataRow("djddk", 4, 25)]
        [DataRow("dfjdks", 5, 5)]
        public void SeasonTest(string name, int month, int day)
        {
            //Arrange
            var student = new Student(name, month, day);
            


            //Act
            string season = student.Season();
            

            //Assert
            Assert.AreEqual("Spring", season);
            
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void MonthTest()
        {
            //Arrange
            var student = new Student("thibi", 15, 15);

            //Act
            var season = student.Season();

            //Assert
            Assert.Fail();
        }
    }
}