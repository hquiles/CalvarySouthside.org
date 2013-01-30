using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Infrastructure;
using System.Data.SqlClient;

namespace CalvarySouthside
{
    public class Person
    {
        #region Properties

        public int Id { get; set; }
        public DateTime DateRegistered { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public bool ConfirmedEmail { get; set; }
        public bool EmailList { get; set; }
        public string PhoneNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public DateTime Birthday { get; set; }
        public bool Admin { get; set; }

        public string NewPassword { get; set; }

        #endregion

        #region Constructors

        public Person()
        {
        
        }

        /// <summary>
        /// Automatically loads the person
        /// </summary>
        /// <param name="personId"></param>
        public Person(int personId)
        {
            Id = personId;
            LoadPerson();
        }

        #endregion

        #region Methods

        private void LoadPerson()
        {
            DataSet ds = Database.ExecuteStoredProcedure("sp_Person_GetById"
                , new SqlParameter("@Id", Id)
                );

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                DateRegistered = Convert.ToDateTime(dr["DateRegistered"]);
                LastName = dr["LastName"].ToString();
                FirstName = dr["FirstName"].ToString();
                EmailAddress = dr["EmailAddress"].ToString();
                ConfirmedEmail = Convert.ToBoolean(dr["ConfirmedEmail"]);
                EmailList = Convert.ToBoolean(dr["EmailList"]);
                PhoneNumber = dr["PhoneNumber"].ToString();

                Address1 = dr["Address1"].ToString();
                Address2 = dr["Address2"].ToString();
                City = dr["City"].ToString();
                State = dr["State"].ToString();
                Zip = dr["Zip"].ToString();

                Admin = Convert.ToBoolean(dr["Admin"]);
                //,[Birthday]
                //,[PasswordHash]
            }
        }

        /// <summary>
        /// Upserts the current user to the People table
        /// </summary>
        public void Save()
        {
            // upsert
            Database.ExecuteStoredProcedure("sp_Person_Upsert"
                , new SqlParameter("@Id", Id)
                , new SqlParameter("@LastName", LastName)
                , new SqlParameter("@FirstName", FirstName)
                , new SqlParameter("@EmailAddress", EmailAddress)
                , new SqlParameter("@ConfirmedEmail", ConfirmedEmail)
                , new SqlParameter("@EmailList", EmailList)
                , new SqlParameter("@PhoneNumber", PhoneNumber)
                , new SqlParameter("@Address1", Address1)
                , new SqlParameter("@Address2", Address2)
                , new SqlParameter("@City", City)
                , new SqlParameter("@State", State)
                , new SqlParameter("@Zip", Zip)
                , new SqlParameter("@Admin", Admin)
                );

            if (!string.IsNullOrEmpty(NewPassword))
                Authentication.SetPassword(EmailAddress, NewPassword);
        }

        #endregion


    }
}
