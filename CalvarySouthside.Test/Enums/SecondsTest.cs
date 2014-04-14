using CalvarySouthside.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalvarySouthside.Test.Enums
{
    [TestClass]
    public class SecondsTest
    {
        [TestMethod]
        public void CalculatedValuesAreCorrect()
        {
            Assert.AreEqual(60, (int)Seconds.OneMinute);
            Assert.AreEqual(3600, (int)Seconds.OneHour);
            Assert.AreEqual(86400, (int)Seconds.OneDay);
            Assert.AreEqual(604800, (int)Seconds.OneWeek);
            Assert.AreEqual(2592000, (int)Seconds.OneMonth);
            Assert.AreEqual(31536000, (int)Seconds.OneYear);
        }
    }
}
