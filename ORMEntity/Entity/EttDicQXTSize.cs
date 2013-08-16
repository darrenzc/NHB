using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ORM.Common;

namespace System.ORM.Entity
{
    [Serializable]
    [Table(Name="DicQXTSize")]
    public class EttDicQXTSize
    {
        ChangeFields cf = new ChangeFields();
        public enum e
        {
            SYMC,
            BOOKMARK,
            QXTWIDTH,
            QXTHEIGHT
        }

        private string _SYMC;
        private string _BOOKMARK;
        private float _QXTWIDTH;
        private float _QXTHEIGHT;

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

        [Column(Name = "BOOKMARK")]
        public string BOOKMARK
        {
            get { return _BOOKMARK; }
            set
            {
                _BOOKMARK = value;
                cf.Add("BOOKMARK");
            }
        }

        [Column(Name = "QXTWIDTH")]
        public float QXTWIDTH
        {
            get { return _QXTWIDTH; }
            set
            {
                _QXTWIDTH = value;
                cf.Add("QXTWIDTH");
            }
        }

        [Column(Name = "QXTHEIGHT")]
        public float QXTHEIGHT
        {
            get { return _QXTHEIGHT; }
            set
            {
                _QXTHEIGHT = value;
                cf.Add("QXTHEIGHT");
            }
        }
    }
}
