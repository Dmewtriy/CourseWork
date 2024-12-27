using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWork1;

namespace CourseWork1.Tests
{
    [TestClass()]
    public class TripTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializePropertiesCorrectly()
        {
            // Arrange
            long id = 1;
            string routeName = "Маршрут 1";
            ICompanyRepresentative representative = new CompanyRepresentative(1, "Иван", "Иванов", "Иванович", "1234567890", "ivan.ivanov@example.com");
            int price = 10000;
            DateTime startDate = new DateTime(2024, 5, 1);
            DateTime endDate = new DateTime(2024, 5, 10);
            int touristNumber = 20;
            List<IClient> tourists = new List<IClient>(); // Заполнить клиентами для теста
            int penalty = 1000;

            // Act
            var trip = new Trip(id, routeName, representative, price, startDate, endDate, touristNumber, tourists, penalty);

            // Assert
            Assert.AreEqual(id, trip.Id);
            Assert.AreEqual(routeName, trip.RouteName);
            Assert.AreEqual(representative, trip.Representative);
            Assert.AreEqual(price, trip.Price);
            Assert.AreEqual(startDate, trip.StartDate);
            Assert.AreEqual(endDate, trip.EndDate);
            Assert.AreEqual(touristNumber, trip.TouristNumber);
            Assert.AreEqual(tourists, trip.Tourists);
            Assert.AreEqual(penalty, trip.Penalty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RouteName_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var trip = CreateValidTrip();

            // Act
            trip.RouteName = ""; // Invalid route name
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Representative_ShouldThrowException_WhenNull()
        {
            // Arrange
            var trip = CreateValidTrip();

            // Act
            trip.Representative = null; // Invalid representative
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Price_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var trip = CreateValidTrip();

            // Act
            trip.Price = -1; // Invalid price
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EndDate_ShouldThrowException_WhenBeforeStartDate()
        {
            // Arrange
            var trip = CreateValidTrip();

            // Act
            trip.EndDate = trip.StartDate.AddDays(-1); // Invalid end date before start date
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TouristNumber_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var trip = CreateValidTrip();

            // Act
            trip.TouristNumber = 0; // Invalid tourist number
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Tourists_ShouldThrowException_WhenNull()
        {
            // Arrange
            var trip = CreateValidTrip();

            // Act
            trip.Tourists = null; // Invalid tourists list
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Penalty_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var trip = CreateValidTrip();

            // Act
            trip.Penalty = -1; // Invalid penalty
        }

        [TestMethod]
        public void ToString_ShouldReturnCorrectFormat()
        {
            // Arrange
            var trip = CreateValidTrip();

            // Act
            var result = trip.ToString();

            // Assert
            string expected = "1 Маршрут 1 Иванов Иван Иванович 10000 01.05.2024 10.05.2024 20 1000";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Equals_ShouldReturnTrue_WhenSameId()
        {
            // Arrange
            var trip1 = CreateValidTrip();
            var trip2 = new Trip(trip1.Id, "Маршрут 2", trip1.Representative, 15000, trip1.StartDate, trip1.EndDate, 25, trip1.Tourists, 2000);

            // Act
            var isEqual = trip1.Equals(trip2);

            // Assert
            Assert.IsTrue(isEqual);
        }

        [TestMethod]
        public void Equals_ShouldReturnFalse_WhenDifferentId()
        {
            // Arrange
            var trip1 = CreateValidTrip();
            var trip2 = new Trip(2, "Маршрут 2", trip1.Representative, 15000, trip1.StartDate, trip1.EndDate, 25, trip1.Tourists, 2000);

            // Act
            var isEqual = trip1.Equals(trip2);

            // Assert
            Assert.IsFalse(isEqual);
        }

        private Trip CreateValidTrip()
        {
            var representative = new CompanyRepresentative(1, "Иван", "Иванов", "Иванович", "1234567890", "ivan.ivanov@example.com");
            var tourists = new List<IClient>(); // Можно добавить клиентов для теста
            return new Trip(
                1,
                "Маршрут 1",
                representative,
                10000,
                new DateTime(2024, 5, 1),
                new DateTime(2024, 5, 10),
                20,
                tourists,
                1000
            );
        }
    }
}