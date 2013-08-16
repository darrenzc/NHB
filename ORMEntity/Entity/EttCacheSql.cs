using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ORM.Common;

namespace System.ORM.Entity
{
    [Serializable]
    [Table(Name="CacheSql")]
    public class EttCacheSql
    {
        ChangeFields cf = new ChangeFields();

        public enum e
        { 
            ID,
            cDate,
            strSql
        }

        private int id;
        private DateTime cDate;
        private string strSql;

        [Column(Name = "ID")]
        public int ID
        {
            get { return id; }
            set
            {
                id = value;
                cf.Add("ID");
            }
        }

        [Column(Name = "cDate")]
        public DateTime CDate
        {
            get { return cDate; }
            set
            {
                cDate = value;
                cf.Add("cDate");
            }
        }

        [Column(Name = "strSql")]
        public string StrSql
        {
            get { return strSql; }
            set
            {
                strSql = value;
                cf.Add("strSql");
            }
        }
    }
}
