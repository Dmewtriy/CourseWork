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
    public class CompanyRepresentativeTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializePropertiesCorrectly()
        {
            // Arrange
            long id = 1;
            string firstName = "Иван";
            string lastName = "Иванов";
            string patronymic = "Иванович";
            string number = "1234567890";
            string email = "ivan.ivanov@example.com";

            // Act
            var representative = new CompanyRepresentative(id, firstName, lastName, patronymic, number, email);

            // Assert
            Assert.AreEqual(id, representative.Id);
            Assert.AreEqual(firstName, representative.FirstName);
            Assert.AreEqual(lastName, representative.LastName);
            Assert.AreEqual(patronymic, representative.Patronymic);
            Assert.AreEqual(number, representative.Number);
            Assert.AreEqual(email, representative.Email);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FirstName_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var representative = CreateValidRepresentative();

            // Act
            representative.FirstName = ""; // Invalid first name
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LastName_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var representative = CreateValidRepresentative();

            // Act
            representative.LastName = ""; // Invalid last name
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Patronymic_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var representative = CreateValidRepresentative();

            // Act
            representative.Patronymic = ""; // Invalid patronymic
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Number_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var representative = CreateValidRepresentative();

            // Act
            representative.Number = ""; // Invalid phone number
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Email_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var representative = CreateValidRepresentative();

            // Act
            representative.Email = ""; // Invalid email
        }

        [TestMethod]
        public void GetName_ShouldReturnCorrectFullName()
        {
            // Arrange
            var representative = CreateValidRepresentative();

            // Act
            var result = representative.GetName();

            // Assert
            string expected = "Иванов Иван Иванович";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToString_ShouldReturnCorrectFormat()
        {
            // Arrange
            var representative = CreateValidRepresentative();

            // Act
            var result = representative.ToString();

            // Assert
            string expected = "1 Иванов Иван Иванович 1234567890 ivan.ivanov@example.com";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Equals_ShouldReturnTrue_WhenSameId()
        {
            // Arrange
            var rep1 = CreateValidRepresentative();
            var rep2 = new CompanyRepresentative(rep1.Id, "Другой", "Имя", "Отчество", "0987654321", "other.email@example.com");

            // Act
            var isEqual = rep1.Equals(rep2);

            // Assert
            Assert.IsTrue(isEqual);
        }

        [TestMethod]
        public void Equals_ShouldReturnFalse_WhenDifferentId()
        {
            // Arrange
            var rep1 = CreateValidRepresentative();
            var rep2 = new CompanyRepresentative(2, "Другой", "Имя", "Отчество", "0987654321", "other.email@example.com");

            // Act
            var isEqual = rep1.Equals(rep2);

            // Assert
            Assert.IsFalse(isEqual);
        }

        private CompanyRepresentative CreateValidRepresentative()
        {
            return new CompanyRepresentative(
                1,
                "Иван",
                "Иванов",
                "Иванович",
                "1234567890",
                "ivan.ivanov@example.com"
            );
        }
    }
}