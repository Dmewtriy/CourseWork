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
    public class ExcursionTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializePropertiesCorrectly()
        {
            // Arrange
            long id = 1;
            string name = "Горная прогулка";
            string description = "Экскурсия по горам с профессиональным гидом";

            // Act
            var excursion = new Excursion(id, name, description);

            // Assert
            Assert.AreEqual(id, excursion.Id);
            Assert.AreEqual(name, excursion.Name);
            Assert.AreEqual(description, excursion.Description);
        }

        [TestMethod]
        public void Id_ShouldSetCorrectly_WhenValidValue()
        {
            // Arrange
            var excursion = new Excursion(1, "Горная прогулка", "Описание");

            // Act
            excursion.Id = 10;

            // Assert
            Assert.AreEqual(10, excursion.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Id_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var excursion = new Excursion(1, "Горная прогулка", "Описание");

            // Act
            excursion.Id = -5; // Invalid ID
        }

        [TestMethod]
        public void Name_ShouldSetCorrectly_WhenValidValue()
        {
            // Arrange
            var excursion = new Excursion(1, "Горная прогулка", "Описание");

            // Act
            excursion.Name = "Лесная прогулка";

            // Assert
            Assert.AreEqual("Лесная прогулка", excursion.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Name_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var excursion = new Excursion(1, "Горная прогулка", "Описание");

            // Act
            excursion.Name = ""; // Invalid name
        }

        [TestMethod]
        public void Description_ShouldSetCorrectly_WhenValidValue()
        {
            // Arrange
            var excursion = new Excursion(1, "Горная прогулка", "Описание");

            // Act
            excursion.Description = "Новое описание экскурсии";

            // Assert
            Assert.AreEqual("Новое описание экскурсии", excursion.Description);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Description_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var excursion = new Excursion(1, "Горная прогулка", "Описание");

            // Act
            excursion.Description = null; // Invalid description
        }

        [TestMethod]
        public void Equals_ShouldReturnTrue_WhenIdsAreEqual()
        {
            // Arrange
            var excursion1 = new Excursion(1, "Экскурсия 1", "Описание 1");
            var excursion2 = new Excursion(1, "Экскурсия 2", "Описание 2");

            // Act
            bool areEqual = excursion1.Equals(excursion2);

            // Assert
            Assert.IsTrue(areEqual);
        }

        [TestMethod]
        public void Equals_ShouldReturnFalse_WhenIdsAreDifferent()
        {
            // Arrange
            var excursion1 = new Excursion(1, "Экскурсия 1", "Описание 1");
            var excursion2 = new Excursion(2, "Экскурсия 2", "Описание 2");

            // Act
            bool areEqual = excursion1.Equals(excursion2);

            // Assert
            Assert.IsFalse(areEqual);
        }

        [TestMethod]
        public void Equals_ShouldReturnFalse_WhenObjectIsNotExcursion()
        {
            // Arrange
            var excursion = new Excursion(1, "Экскурсия", "Описание");
            var notAnExcursion = new object();

            // Act
            bool areEqual = excursion.Equals(notAnExcursion);

            // Assert
            Assert.IsFalse(areEqual);
        }
    }
}