using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DatePzw;

namespace DateUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMonth1()
        {
            var date = new Date(2003, 1, 1);
            Assert.AreEqual("January", date.getMonthName(), "Month 1 should return name January");
        }
        [TestMethod]
        public void TestMonth2()
        {
            var date = new Date(2003, 2, 1);
            Assert.AreEqual("February", date.getMonthName(), "Month 2 should return name February");
        }
        [TestMethod]
        public void TestMonth3()
        {
            var date = new Date(2003, 3, 1);
            Assert.AreEqual("March", date.getMonthName(), "Month 3 should return name March");
        }
        [TestMethod]
        public void TestMonth4()
        {
            var date = new Date(2003, 4, 1);
            Assert.AreEqual("April", date.getMonthName(), "Month 4 should return name April");
        }
        [TestMethod]
        public void TestMonth5()
        {
            var date = new Date(2003, 5, 1);
            Assert.AreEqual("May", date.getMonthName(), "Month 5 should return name May");
        }
        [TestMethod]
        public void TestMonth6()
        {
            var date = new Date(2003, 6, 1);
            Assert.AreEqual("June", date.getMonthName(), "Month 6 should return name June");
        }
        [TestMethod]
        public void TestMonth7()
        {
            var date = new Date(2003, 7, 1);
            Assert.AreEqual("July", date.getMonthName(), "Month 7 should return name July");
        }
        [TestMethod]
        public void TestMonth8()
        {
            var date = new Date(2003, 8, 1);
            Assert.AreEqual("August", date.getMonthName(), "Month 8 should return name August");
        }
        [TestMethod]
        public void TestMonth9()
        {
            var date = new Date(2003, 9, 1);
            Assert.AreEqual("September", date.getMonthName(), "Month 9 should return name September");
        }
        [TestMethod]
        public void TestMonth10()
        {
            var date = new Date(2003, 10, 1);
            Assert.AreEqual("October", date.getMonthName(), "Month 10 should return name October");
        }
        [TestMethod]
        public void TestMonth11()
        {
            var date = new Date(2003, 11, 1);
            Assert.AreEqual("November", date.getMonthName(), "Month 11 should return name November");
        }
        [TestMethod]
        public void TestMonth12()
        {
            var date = new Date(2003, 12, 1);
            Assert.AreEqual("December", date.getMonthName(), "Month 12 should return name December");
        }
        [TestMethod]
        public void TestInvalidMonth()
        {
            var date = new Date(2003, 55, 1);
            Assert.AreEqual("Invalid month", date.getMonthName(), "An invalid month should return an error message");
        }

        [TestMethod]
        public void TestRemainingDaysInMonthWith31Days()
        {
            var date = new Date(2015, 3, 25);
            Assert.AreEqual(6, date.getNumberOfRemainingDaysInMonth(), "getNumberOfRemainingDaysInMonth should return the number of remaining days in a month with 31 days");
        }
        [TestMethod]
        public void TestRemainingDaysInMonthWith30Days()
        {
            var date = new Date(2015, 9, 25);
            Assert.AreEqual(5, date.getNumberOfRemainingDaysInMonth(), "getNumberOfRemainingDaysInMonth should return the number of remaining days in a month with 30 days");
        }
        [TestMethod]
        public void TestRemainingDaysInMonthWith29Days()
        {
            var date = new Date(2016, 2, 25);
            Assert.AreEqual(4, date.getNumberOfRemainingDaysInMonth(), "getNumberOfRemainingDaysInMonth should return the number of remaining days in February in a leap year (29 days)");
        }
        [TestMethod]
        public void TestRemainingDaysInMonthWith28Days()
        {
            var date = new Date(2015, 2, 25);
            Assert.AreEqual(3, date.getNumberOfRemainingDaysInMonth(), "getNumberOfRemainingDaysInMonth should return the number of remaining days in February in a non-leap year (28 days)");
        }
        [TestMethod]
        public void TestRemainingDaysInInvalidMonth()
        {
            var date = new Date(2015, 13, 1);
            Assert.AreEqual(-1, date.getNumberOfRemainingDaysInMonth(), "getNumberOfRemainingDaysInMonth should return -1 if the month is invalid");
        }
        [TestMethod]
        public void TestRemainingDaysWithInvalidDayInMonthWith31Days()
        {
            var date = new Date(2015, 12, 41);
            Assert.AreEqual(-1, date.getNumberOfRemainingDaysInMonth(), "getNumberOfRemainingDaysInMonth should return -1 if the day is invalid");
        }
        [TestMethod]
        public void TestRemainingDaysWithInvalidDayInMonthWith30Days()
        {
            var date = new Date(2015, 11, 41);
            Assert.AreEqual(-1, date.getNumberOfRemainingDaysInMonth(), "getNumberOfRemainingDaysInMonth should return -1 if the day is invalid");
        }
        [TestMethod]
        public void TestRemainingDaysWithInvalidDayInMonthWith29Days()
        {
            var date = new Date(2016, 2, 41);
            Assert.AreEqual(-1, date.getNumberOfRemainingDaysInMonth(), "getNumberOfRemainingDaysInMonth should return -1 if the day is invalid");
        }
        [TestMethod]
        public void TestRemainingDaysWithInvalidDayInMonthWith28Days()
        {
            var date = new Date(2015, 2, 41);
            Assert.AreEqual(-1, date.getNumberOfRemainingDaysInMonth(), "getNumberOfRemainingDaysInMonth should return -1 if the day is invalid");
        }

        [TestMethod]
        public void TestNonLeapYearNotDivisibleBy4()
        {
            var date = new Date(2017, 11, 25);
            Assert.AreEqual(false, date.isLeapYear(), "A year not divisible by 4 is not a leap year");
        }
        [TestMethod]
        public void TestNonLeapYearDivisibleBy4and100ButNotBy400()
        {
            var date = new Date(2100, 11, 25);
            Assert.AreEqual(false, date.isLeapYear(), "A year divisible by 4 and 100 but not by 400 is not a leap year");
        }
        [TestMethod]
        public void TestLeapYearDivisibleBy4ButNotBy100()
        {
            var date = new Date(2016, 11, 25);
            Assert.AreEqual(true, date.isLeapYear(), "A year divisible by 4 but not by 100 is a leap year");
        }
        [TestMethod]
        public void TestLeapYearDivisibleBy400()
        {
            var date = new Date(2400, 11, 25);
            Assert.AreEqual(true, date.isLeapYear(), "A year divisible by 400 is a leap year");
        }
    }
}
