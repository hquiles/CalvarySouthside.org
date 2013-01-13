using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Infrastructure;

namespace CalvarySouthside
{
    public class PraiseReport : PrayerRequest
    {
        #region Properties

        #endregion

        #region Methods

        public override void Submit()
        {
            Database.ExecuteStoredProcedure("sp_PraiseReport_Insert",
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
