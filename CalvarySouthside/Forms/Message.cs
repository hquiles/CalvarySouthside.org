using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalvarySouthside.Infrastructure;
using System.Data.SqlClient;
using System.Data;
using THREE17.Core.Communication;

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
        public Guid Key { get; set; }
        public MessageType MessageType { get; set; }
        public bool Anonymous { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string MessageBody { get; set; }
        public DateTime Date { get; set; }

        #endregion

        #region Constructors

        public Message()
        {
            
        }

        /// <summary>
        /// Load by Id
        /// </summary>
        /// <param name="id"></param>
        public Message(int id)
        {
            DataSet ds = Database.ExecuteStoredProcedure("sp_Message_GetById"
                , new SqlParameter("@Id", id)
                );

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                FillFromDataRow(ds.Tables[0].Rows[0]);
        }

        /// <summary>
        /// Load by Key
        /// </summary>
        /// <param name="key"></param>
        public Message(Guid key)
        {
            DataSet ds = Database.ExecuteStoredProcedure("sp_Message_GetByKey"
                , new SqlParameter("@Key", key)
                );

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                FillFromDataRow(ds.Tables[0].Rows[0]);
        }

        /// <summary>
        /// Instantiate with data
        /// </summary>
        /// <param name="dr"></param>
        public Message(DataRow dr)
        {
            FillFromDataRow(dr);
        }

        #endregion

        #region Methods

        private void FillFromDataRow(DataRow dr)
        {
            Guid tempKey;
            if (!Guid.TryParse(dr["Key"].ToString(), out tempKey))
                tempKey = Guid.Empty;
            Key = tempKey;

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

        public virtual void Submit()
        {
            Key = Guid.NewGuid();

            StringBuilder sbEmailMessage = new StringBuilder();
            sbEmailMessage.AppendFormat("Type: {0}<br />", MessageType);
            sbEmailMessage.AppendFormat("Name: {0} {1}<br />", FirstName, LastName);
            sbEmailMessage.AppendFormat("Request Anonymity{0}<br />", Anonymous);
            sbEmailMessage.AppendFormat("Email Address: {0}<br />", MessageType);
            sbEmailMessage.AppendFormat("Message: {0}<br />", MessageBody);

            Email.Send(to: "bharrison912@gmail.com"
                ,subject: "New Website Message"
                ,message: sbEmailMessage.ToString()
                );

            Database.ExecuteStoredProcedure("sp_Message_Insert"
                , new SqlParameter("@Key", Key)
                , new SqlParameter("@MessageType", MessageType)
                , new SqlParameter("@Anonymous", Anonymous)
                , new SqlParameter("@LastName", LastName ?? string.Empty)
                , new SqlParameter("@FirstName", FirstName ?? string.Empty)
                , new SqlParameter("@EmailAddress", EmailAddress ?? string.Empty)
                , new SqlParameter("@MessageBody", MessageBody ?? string.Empty)
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
