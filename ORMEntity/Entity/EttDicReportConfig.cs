using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ORM.Common;

namespace System.ORM.Entity
{
    [Serializable]
    [Table(Name="DicReportConfig")]
    public class EttDicReportConfig
    {
        ChangeFields cf = new ChangeFields();
        public enum e
        {
            SYMC,
            DBNAME,
            FIELD,
            MULTI,
            Graph,
            FILLNUM,
            BGMC
        }

        private string _SYMC;
        private string _DBNAME;
        private string _FIELD;
        private bool _MULTI;
        private bool _Graph;
        private int _FILLNUM;
        private string _BGMC;

        [Column(Name = "SYMC")]
        public string SYMC
        {
            get { return _SYMC; }
            set
            {
                _SYMC = value;
                cf.Add("SYMC");
            }
        }

        [Column(Name = "DBNAME")]
        public string DBNAME
        {
            get { return _DBNAME; }
            set
            {
                _DBNAME = value;
                cf.Add("DBNAME");
            }
        }

        [Column(Name = "FIELD")]
        public string FIELD
        {
            get { return _FIELD; }
            set
            {
                _FIELD = value;
                cf.Add("FIELD");
            }
        }

        [Column(Name = "MULTI")]
        public bool MULTI
        {
            get { return _MULTI; }
            set
            {
                _MULTI = value;
                cf.Add("MULTI");
            }
        }

        [Column(Name = "Graph")]
        public bool Graph
        {
            get { return _Graph; }
            set
            {
                _Graph = value;
                cf.Add("Graph");
            }
        }

        [Column(Name = "FILLNUM")]
        public int FILLNUM
        {
            get { return _FILLNUM; }
            set
            {
                _FILLNUM = value;
                cf.Add("FILLNUM");
            }
        }

        [Column(Name = "BGMC")]
        public string BGMC
        {
            get { return _BGMC; }
            set
            {
                _BGMC = value;
                cf.Add("BGMC");
            }
        }
    }
}
