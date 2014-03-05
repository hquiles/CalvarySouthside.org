using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalvarySouthside.Infrastructure;
using System.Data.SqlClient;
using System.Data;

namespace CalvarySouthside
{
    public class BibleStudy
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Scripture { get; set; }
        public string Description { get; set; }
        public string Hyperlink { get; set; }

        #region Constructor(s)

        public BibleStudy()
        {
        
        }

        public BibleStudy(DataRow dr)
        {
            Id = Convert.ToInt32(dr["Id"]);
            Date = Convert.ToDateTime(dr["Date"]);
            Scripture = dr["Scripture"].ToString();
            Description = dr["Description"].ToString();
            Hyperlink = dr["Hyperlink"].ToString();
        }

        #endregion

        #region Instance Methods

        public void Save()
        {
            Database.ExecuteStoredProcedure("sp_BibleStudy_Upsert"
                , new SqlParameter("@Id", Id)
                , new SqlParameter("@Date", Date)
                , new SqlParameter("@Scripture", Scripture)
                , new SqlParameter("@Description", Description)
                , new SqlParameter("@Hyperlink", Hyperlink)
                );
        }

        #endregion

        #region Static Methods

        public static List<BibleStudy> GetLatest()
        {
            DataSet ds = Database.ExecuteStoredProcedure("sp_BibleStudy_GetLatest");

            List<BibleStudy> bibleStudy = new List<BibleStudy>();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                    bibleStudy.Add(new BibleStudy(dr));
            }

            return bibleStudy;
        }

        #endregion

    }
}
