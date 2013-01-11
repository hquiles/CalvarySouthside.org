using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalvarySouthside
{
    public class PrayerRequest
    {
        #region Properties

        public bool Prayer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }
        public bool Anonymous { get; set; }

        #endregion

        #region Methods

        public void Submit()
        {
            // insert into database
        }

        #endregion
    }
}
