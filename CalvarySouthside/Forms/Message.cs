using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infrastructure;
using System.Data.SqlClient;

namespace CalvarySouthside.Forms
{
    public enum MessageType
    {
        General,
        PrayerRequest,
        PraiseReport
    }

    public class Message
    {
        #region Properties

        public MessageType MessageType { get; set; }
        public bool Anonymous { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string MessageBody { get; set; }

        #endregion

        #region Methods

        public virtual void Submit()
        {
            Database.ExecuteStoredProcedure("sp_Message_Insert"
                , new SqlParameter("@MessageType", MessageType)
                , new SqlParameter("@Anonymous", Anonymous)
                , new SqlParameter("@LastName", LastName)
                , new SqlParameter("@FirstName", FirstName)
                , new SqlParameter("@EmailAddress", EmailAddress)
                , new SqlParameter("@MessageBody", MessageBody)
                );

        }

        #endregion
    }
}
