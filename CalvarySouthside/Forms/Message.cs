using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infrastructure;
using System.Data.SqlClient;
using System.Data;

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

        public int Id { get; set; }
        public MessageType MessageType { get; set; }
        public bool Anonymous { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string MessageBody { get; set; }
        public DateTime Date { get; set; }

        #endregion

        #region Constructor

        public Message()
        {
            
        }

        public Message(DataRow dr)
        {
            Id = Convert.ToInt32(dr["Id"]);
            MessageType = (MessageType)Convert.ToInt32(dr["MessageType"]);
            Anonymous = Convert.ToBoolean(dr["Anonymous"]);
            LastName = dr["LastName"].ToString();
            FirstName = dr["FirstName"].ToString();
            EmailAddress = dr["EmailAddress"].ToString();
            MessageBody = dr["MessageBody"].ToString();

            DateTimeOffset dto = (DateTimeOffset)dr["Date"];
            Date = dto.LocalDateTime;
        }

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

        public static List<Message> GetLatest()
        {
            DataSet ds = Database.ExecuteStoredProcedure("sp_Messages_GetLatest");

            var messages = new List<Message>();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                    messages.Add(new Message(dr));
            }

            return messages;
        }

        #endregion
    }
}
