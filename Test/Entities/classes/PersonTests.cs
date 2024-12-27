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
    public class PersonTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializePropertiesCorrectly()
        {
            // Arrange
            string firstName = "Иван";
            string lastName = "Иванов";
            string patronymic = "Иванович";

            // Act
            var person = new Person(firstName, lastName, patronymic);

            // Assert
            Assert.AreEqual(firstName, person.FirstName);
            Assert.AreEqual(lastName, person.LastName);
            Assert.AreEqual(patronymic, person.Patronymic);
        }

        [TestMethod]
        public void GetName_ShouldReturnFullName()
        {
            // Arrange
            var person = new Person("Иван", "Иванов", "Иванович");

            // Act
            var fullName = person.GetName();

            // Assert
            Assert.AreEqual("Иванов Иван Иванович", fullName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FirstName_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var person = new Person("Иван", "Иванов", "Иванович");

            // Act
            person.FirstName = ""; // Invalid first name
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LastName_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var person = new Person("Иван", "Иванов", "Иванович");

            // Act
            person.LastName = null; // Invalid last name
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Patronymic_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var person = new Person("Иван", "Иванов", "Иванович");

            // Act
            person.Patronymic = "  "; // Invalid patronymic
        }

        [TestMethod]
        public void FirstName_ShouldSetCorrectly_WhenValidValue()
        {
            // Arrange
            var person = new Person("Иван", "Иванов", "Иванович");

            // Act
            person.FirstName = "Петр";

            // Assert
            Assert.AreEqual("Петр", person.FirstName);
        }

        [TestMethod]
        public void LastName_ShouldSetCorrectly_WhenValidValue()
        {
            // Arrange
            var person = new Person("Иван", "Иванов", "Иванович");

            // Act
            person.LastName = "Петров";

            // Assert
            Assert.AreEqual("Петров", person.LastName);
        }

        [TestMethod]
        public void Patronymic_ShouldSetCorrectly_WhenValidValue()
        {
            // Arrange
            var person = new Person("Иван", "Иванов", "Иванович");

            // Act
            person.Patronymic = "Алексеевич";

            // Assert
            Assert.AreEqual("Алексеевич", person.Patronymic);
        }
    }
}
