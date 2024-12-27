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
    public class RUPassportTests
    {
        [TestMethod()]
        public void CheckGetTest()
        {
            // Arrange
            var series = "1234";
            var number = "567890";
            var issuedDate = new DateTime(2020, 1, 1);
            var issuedBy = "УФМС России";

            // Act
            var passport = new RUPassport(series, number, issuedDate, issuedBy);

            // Assert
            Assert.AreEqual(series, passport.Series);
            Assert.AreEqual(number, passport.Number);
            Assert.AreEqual(issuedDate, passport.IssuedDate);
            Assert.AreEqual(issuedBy, passport.IssuedBy);
        }
        [TestMethod()]
        public void ToStringTest()
        {
            // Arrange
            var passport = new RUPassport("1234", "567890", DateTime.Now, "УФМС России");

            // Act
            var result = passport.ToString();

            // Assert
            Assert.AreEqual("1234 567890", result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SeriesSetThrowException()
        {
            // Arrange
            var passport = new RUPassport("1234", "567890", DateTime.Now, "УФМС России");

            // Act
            passport.Series = "12"; // Invalid series
        }
        [TestMethod]
        public void SeriesSetTest()
        {
            // Arrange
            var passport = new RUPassport("1234", "567890", DateTime.Now, "УФМС России");

            // Act
            passport.Series = "9876";

            // Assert
            Assert.AreEqual("9876", passport.Series);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NumberSetExceptionWhen()
        {
            // Arrange
            var passport = new RUPassport("1234", "567890", DateTime.Now, "УФМС России");

            // Act
            passport.Number = "12345"; // Invalid number
        }
        [TestMethod]
        public void NumberSetTest()
        {
            // Arrange
            var passport = new RUPassport("1234", "567890", DateTime.Now, "УФМС России");

            // Act
            passport.Number = "654321";

            // Assert
            Assert.AreEqual("654321", passport.Number);
        }

        [TestMethod]
        public void IssuedDatSetTest()
        {
            // Arrange
            var passport = new RUPassport("1234", "567890", DateTime.Now, "УФМС России");
            var validDate = new DateTime(2022, 5, 10);

            // Act
            passport.IssuedDate = validDate;

            // Assert
            Assert.AreEqual(validDate, passport.IssuedDate);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void IssuedException()
        {
            // Arrange
            var passport = new RUPassport("1234", "567890", DateTime.Now, "УФМС России");

            // Act
            passport.IssuedBy = ""; // Invalid value
        }

        [TestMethod]
        public void IssuedBySetTest()
        {
            // Arrange
            var passport = new RUPassport("1234", "567890", DateTime.Now, "УФМС России");

            // Act
            passport.IssuedBy = "ГУ МВД России";

            // Assert
            Assert.AreEqual("ГУ МВД России", passport.IssuedBy);
        }
    }
}