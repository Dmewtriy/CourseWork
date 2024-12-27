using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseWork1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.Tests
{
    [TestClass]
    public class RouteTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializePropertiesCorrectly()
        {
            // Arrange
            long id = 1;
            string name = "Маршрут путешествия";
            string country = "Россия";
            int duration = 10;
            var points = new List<IRoutePoint>();

            // Act
            var route = new Route(id, name, country, duration, points);

            // Assert
            Assert.AreEqual(id, route.Id);
            Assert.AreEqual(name, route.Name);
            Assert.AreEqual(country, route.Country);
            Assert.AreEqual(duration, route.Duration);
            Assert.AreEqual(points, route.Points);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Name_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var route = new Route(1, "ValidName", "Russia", 10, new List<IRoutePoint>());

            // Act
            route.Name = ""; // Invalid name
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Country_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var route = new Route(1, "ValidName", "Russia", 10, new List<IRoutePoint>());

            // Act
            route.Country = null; // Invalid country
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Duration_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var route = new Route(1, "ValidName", "Russia", 10, new List<IRoutePoint>());

            // Act
            route.Duration = 0; // Invalid duration
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Points_ShouldThrowException_WhenNull()
        {
            // Arrange
            var route = new Route(1, "ValidName", "Russia", 10, new List<IRoutePoint>());

            // Act
            route.Points = null; // Invalid points list
        }

        [TestMethod]
        public void Equals_ShouldReturnTrue_WhenSameId()
        {
            // Arrange
            var route1 = new Route(1, "Маршрут 1", "Россия", 10, new List<IRoutePoint>());
            var route2 = new Route(1, "Маршрут 2", "США", 15, new List<IRoutePoint>());

            // Act
            var isEqual = route1.Equals(route2);

            // Assert
            Assert.IsTrue(isEqual);
        }

        [TestMethod]
        public void Equals_ShouldReturnFalse_WhenDifferentId()
        {
            // Arrange
            var route1 = new Route(1, "Маршрут 1", "Россия", 10, new List<IRoutePoint>());
            var route2 = new Route(2, "Маршрут 2", "Россия", 10, new List<IRoutePoint>());

            // Act
            var isEqual = route1.Equals(route2);

            // Assert
            Assert.IsFalse(isEqual);
        }

        [TestMethod]
        public void ToString_ShouldReturnCorrectFormat()
        {
            // Arrange
            var route = new Route(1, "Маршрут 1", "Россия", 10, new List<IRoutePoint>());

            // Act
            var result = route.ToString();

            // Assert
            Assert.AreEqual("1 Маршрут 1 Россия 10", result);
        }

        [TestMethod]
        public void SetAndGetProperties_ShouldWorkCorrectly()
        {
            // Arrange
            var route = new Route(1, "InitialName", "InitialCountry", 5, new List<IRoutePoint>());
            var points = new List<IRoutePoint>();

            // Act
            route.Name = "NewName";
            route.Country = "NewCountry";
            route.Duration = 15;
            route.Points = points;

            // Assert
            Assert.AreEqual("NewName", route.Name);
            Assert.AreEqual("NewCountry", route.Country);
            Assert.AreEqual(15, route.Duration);
            Assert.AreEqual(points, route.Points);
        }
    }
}