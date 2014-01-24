using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Helpers
{
    public static class StringHelper
    {
        /// <summary>
        /// Strips out any non-numeric characters
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string StripNonNumeric(string inputString)
        {
            string numbersOnly = string.Empty;

            if (!string.IsNullOrEmpty(inputString))
            {
                foreach (char ch in inputString)
                {
                    int num;
                    if (int.TryParse(ch.ToString(), out num))
                        numbersOnly += ch;
                }
            }

            return numbersOnly;
        }

        #region Phone

        /// <summary>
        /// Cleanly formats a phone number
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public static string FormatPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return string.Empty;

            string numbersOnly = StripNonNumeric(phoneNumber);

            if (numbersOnly.Length == 7)
                return string.Format("{0}-{1}", numbersOnly.Substring(0, 3), numbersOnly.Substring(3, 4));

            if (numbersOnly.Length == 10)
                return string.Format("({0}) {1}-{2}", numbersOnly.Substring(0, 3), numbersOnly.Substring(3, 3), numbersOnly.Substring(6, 4));

            return phoneNumber;
        }

        /// <summary>
        /// Returns the href value for html telephone links
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public static string PhoneNumberLink(string phoneNumber)
        {
            return string.Format("tel:+1{0}",
                StripNonNumeric(phoneNumber)
                );
        }

        #endregion
    }
}
