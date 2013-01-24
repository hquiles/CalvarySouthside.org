using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Infrastructure
{
    public static class Authentication
    {
        public static bool SignIn(string emailAddress, string password)
        {
            string passwordHash;
            string name;
            string userId;

            DataSet ds = Database.ExecuteStoredProcedure("sp_Person_GetPasswordHash"
                , new SqlParameter("@EmailAddress", emailAddress)
                );

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                passwordHash = string.Format("{0}", ds.Tables[0].Rows[0]["PasswordHash"]);
                name = string.Format("{0} {1}", ds.Tables[0].Rows[0]["FirstName"], ds.Tables[0].Rows[0]["LastName"]);
                userId = string.Format("{0}", ds.Tables[0].Rows[0]["Id"]);

                if (BCrypt.Net.BCrypt.Verify(password, passwordHash))
                {
                    System.Web.HttpContext.Current.Session["Name"] = name;
                    System.Web.HttpContext.Current.Session["UserId"] = userId;

                    return true;
                }
            }

            return false;
        }

        public static void SignOut()
        {
            System.Web.HttpContext.Current.Session["Name"] = null;
            System.Web.HttpContext.Current.Session["UserId"] = null;
        }

        public static bool IsAuthenticated
        {
            get
            {
                bool isAuthenticated = true;

                if (System.Web.HttpContext.Current.Session["UserId"] == null)
                    isAuthenticated = false;

                if (System.Web.HttpContext.Current.Session["Name"] == null)
                    isAuthenticated = false;

                return isAuthenticated;
            }
        }

        public static void SetPassword(string emailAddress, string password)
        {
            int workFactor = Convert.ToInt32(ConfigurationManager.AppSettings["BCryptWorkFactor"]);

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password, workFactor);

            Database.ExecuteStoredProcedure("sp_Person_SetPasswordHash"
                , new SqlParameter("@EmailAddress", emailAddress)
                , new SqlParameter("@PasswordHash", passwordHash)
                );
        }
    }
}
