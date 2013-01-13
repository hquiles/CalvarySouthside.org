﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Infrastructure;

namespace CalvarySouthside
{
    public class PrayerRequest
    {
        #region Properties

        public bool Anonymous { get; set; }
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }

        #endregion

        #region Methods

        public virtual void Submit()
        {
            Database.ExecuteStoredProcedure("sp_PrayerRequest_Insert",
                new SqlParameter("@Anonymous", Anonymous),
                new SqlParameter("@PersonId", PersonId),
                new SqlParameter("@LastName", LastName),
                new SqlParameter("@FirstName", FirstName),
                new SqlParameter("@EmailAddress", EmailAddress),
                new SqlParameter("@Message", Message)
                );

        }

        #endregion
    }
}
