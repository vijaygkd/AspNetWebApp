using System;
using Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Modes.Tests
{
    [TestClass]
    public class LogEntryExtensionsTest
    {
        [TestMethod]
        public void GetDateTime_Test()
        {
            var log = new LogEntry()
            {
                Day = 7,
                Month = "MAY",
                Year = 1492,
                Text = ""
            };

            var logDate = log.GetDateTime();

            Assert.IsTrue(logDate.Day == 7);
            Assert.IsTrue(logDate.Month == 5);
            Assert.IsTrue(logDate.Year == 1492);
        }
    }
}
