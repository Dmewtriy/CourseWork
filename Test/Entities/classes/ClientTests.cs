using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseWork1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.Tests
{
    [TestClass()]
    public class ClientTests
    {
        public class ClientClone : IClient
        {
            public long Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Patronymic { get; set; }
            public DateTime DateOfBirth { get; set; }
            public IPassport PassportData { get; set; }
            public string PathToPhoto { get; set; }
            public string GetName()
            {
                return $"{LastName} {FirstName} {Patronymic}";
            }
        }

        public class PassportClone : IPassport
        {
            public string Series { get; set; }
            public string Number { get; set; }
            public DateTime IssuedDate { get; set; }
            public string IssuedBy { get; set; }
        } 

        [TestMethod()]

        public void ToStringTest()
        {
            IClient test = new Client(12, "TestFirstName1", "TestLastName1", "TestPatronymic1", new DateTime(2000, 12, 22), new RUPassport("1232", "024239", new DateTime(2024, 12, 2), "МВФTEST"), "..\\..\\Elements\\TestPhoto.png");
            string expected = "12 TestLastName1 TestFirstName1 TestPatronymic1 22.12.2000 1232 024239";

            Assert.AreEqual(expected, test.ToString());
        }

        [TestMethod()]
        public void GetNameTest()
        {
            IClient test = new Client(12, "TestFirstName1", "TestLastName1", "TestPatronymic1", new DateTime(2000, 12, 22), new RUPassport("1232", "024239", new DateTime(2024, 12, 2), "МВФTEST"), "..\\..\\Elements\\TestPhoto.png");
            string expected = "TestLastName1 TestFirstName1 TestPatronymic1";

            Assert.AreEqual(expected, test.GetName());
        }

        [TestMethod()]
        public void EqualsTest()
        {
            IClient test1 = new Client(12, "TestFirstName1", "TestLastName1", "TestPatronymic1", new DateTime(2000, 12, 22), new RUPassport("1232", "024239", new DateTime(2024, 12, 2), "МВФTEST"), "..\\..\\Elements\\TestPhoto.png");
            IClient test2 = new Client(12, "TestFirstName2", "TestLastName2", "TestPatronymic2", new DateTime(2000, 12, 22), new RUPassport("1232", "024239", new DateTime(2024, 12, 2), "МВФTEST"), "..\\..\\Elements\\TestPhoto.png");
            IClient test3 = new Client(13, "TestFirstName3", "TestLastName3", "TestPatronymic3", new DateTime(2000, 12, 22), new RUPassport("1232", "024239", new DateTime(2024, 12, 2), "МВФTEST"), "..\\..\\Elements\\TestPhoto.png");

            bool expected1 = true;
            bool expected2 = false;

            Assert.AreEqual(expected1, test1.Equals(test2));
            Assert.AreEqual(expected2, test2.Equals(test3));

        }
    }
}