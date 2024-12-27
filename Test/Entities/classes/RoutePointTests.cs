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
    public class RoutePointTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializePropertiesCorrectly()
        {
            // Arrange
            long id = 1;
            string name = "Точка маршрута";
            int stayDuration = 3;
            string hotelName = "Отель Маршрут";
            int hotelClass = 4;
            var excursions = new List<IExcursion>();

            // Act
            var routePoint = new RoutePoint(id, name, stayDuration, hotelName, hotelClass, excursions);

            // Assert
            Assert.AreEqual(id, routePoint.Id);
            Assert.AreEqual(name, routePoint.Name);
            Assert.AreEqual(stayDuration, routePoint.StayDuration);
            Assert.AreEqual(hotelName, routePoint.HotelName);
            Assert.AreEqual(hotelClass, routePoint.HotelClass);
            Assert.AreEqual(excursions, routePoint.Excursions);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Name_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var routePoint = new RoutePoint(1, "ValidName", 3, "Hotel", 3, new List<IExcursion>());

            // Act
            routePoint.Name = ""; // Invalid name
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StayDuration_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var routePoint = new RoutePoint(1, "ValidName", 3, "Hotel", 3, new List<IExcursion>());

            // Act
            routePoint.StayDuration = 0; // Invalid duration
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void HotelName_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var routePoint = new RoutePoint(1, "ValidName", 3, "Hotel", 3, new List<IExcursion>());

            // Act
            routePoint.HotelName = null; // Invalid hotel name
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void HotelClass_ShouldThrowException_WhenInvalidValue()
        {
            // Arrange
            var routePoint = new RoutePoint(1, "ValidName", 3, "Hotel", 3, new List<IExcursion>());

            // Act
            routePoint.HotelClass = 6; // Invalid hotel class
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Excursions_ShouldThrowException_WhenNull()
        {
            // Arrange
            var routePoint = new RoutePoint(1, "ValidName", 3, "Hotel", 3, new List<IExcursion>());

            // Act
            routePoint.Excursions = null; // Invalid excursions list
        }

        [TestMethod]
        public void Equals_ShouldReturnTrue_WhenSameId()
        {
            // Arrange
            var routePoint1 = new RoutePoint(1, "Name", 3, "Hotel", 4, new List<IExcursion>());
            var routePoint2 = new RoutePoint(1, "OtherName", 5, "OtherHotel", 5, new List<IExcursion>());

            // Act
            var isEqual = routePoint1.Equals(routePoint2);

            // Assert
            Assert.IsTrue(isEqual);
        }

        [TestMethod]
        public void Equals_ShouldReturnFalse_WhenDifferentId()
        {
            // Arrange
            var routePoint1 = new RoutePoint(1, "Name", 3, "Hotel", 4, new List<IExcursion>());
            var routePoint2 = new RoutePoint(2, "Name", 3, "Hotel", 4, new List<IExcursion>());

            // Act
            var isEqual = routePoint1.Equals(routePoint2);

            // Assert
            Assert.IsFalse(isEqual);
        }

        [TestMethod]
        public void ToString_ShouldReturnCorrectFormat()
        {
            // Arrange
            var routePoint = new RoutePoint(1, "Точка маршрута", 3, "Отель Маршрут", 4, new List<IExcursion>());

            // Act
            var result = routePoint.ToString();

            // Assert
            Assert.AreEqual("1 Точка маршрута 3 Отель Маршрут 4", result);
        }
    }
}
