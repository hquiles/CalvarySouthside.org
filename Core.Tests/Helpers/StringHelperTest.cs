using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Helpers;

namespace Core.Tests.Helpers
{
    [TestClass]
    public class StringHelperTest
    {
        [TestMethod]
        public void StripNonNumeric_ReturnsExpectedNumbers()
        {
            string numbersOnly = StringHelper.StripNonNumeric("abcd1234");
            Assert.AreEqual("1234", numbersOnly);
        }

        [TestMethod]
        public void StripNonNumeric_ReturnsEmptyString_WhenNoNumbersGiven()
        {
            string numbersOnly = StringHelper.StripNonNumeric("abcd");
            Assert.AreEqual(string.Empty, numbersOnly);
        }

        [TestMethod]
        public void StripNonNumeric_ReturnsEmptyString_WhenNull()
        {
            string numbersOnly = StringHelper.StripNonNumeric(null);
            Assert.AreEqual(string.Empty, numbersOnly);
        }

        [TestMethod]
        public void FormatPhoneNumber_7characters()
        {
            string output = StringHelper.FormatPhoneNumber("4663240");
            Assert.AreEqual("466-3240", output);
        }

        [TestMethod]
        public void FormatPhoneNumber_10characters()
        {
            string output = StringHelper.FormatPhoneNumber("2764663240");
            Assert.AreEqual("(276) 466-3240", output);
        }

        [TestMethod]
        public void FormatPhoneNumber_10characters_PreFormatted()
        {
            string output = StringHelper.FormatPhoneNumber("276-466-3240");
            Assert.AreEqual("(276) 466-3240", output);
        }

        [TestMethod]
        public void FormatPhoneNumber_Null()
        {
            string output = StringHelper.FormatPhoneNumber(null);
            Assert.AreEqual(string.Empty, output);
        }

        [TestMethod]
        public void PhoneNumberLink_Null()
        {
            string output = StringHelper.FormatPhoneNumber("727-555-1234");
            Assert.AreEqual("tel:+17275551234", output);
        }

    }
}
