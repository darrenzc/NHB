using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ORM.Common;

namespace System.ORM.Entity
{
    [Serializable]
    [Table(Name = "TG_CBR_DataList")]
    public class EttTG_CBR_DataList
    {
        ChangeFields cf = new ChangeFields();
        public enum e
        {
            NGUID,
            JSCS,
            SJBH,
            XH,
            HZCLHBFBDU,
            HZYL,
            DWYL,
            GRGBFBDSZ,
            GRGBFBDSY,
            GRGBFBDSPJZ,
            GRL
        }

        private System.String _NGUID;
        private System.String _JSCS;
        private System.String _SJBH;
        private System.Int32 _XH;
        private System.Single _HZCLHBFBDU;
        private System.Single _HZYL;
        private System.Single _DWYL;
        private System.Single _GRGBFBDSZ;
        private System.Single _GRGBFBDSY;
        private System.Single _GRGBFBDSPJZ;
        private System.Single _GRL;

        [Column(Name = "NGUID")]
        public System.String NGUID
        {
            get { return _NGUID; }
            set
            {
                _NGUID = value;
                cf.Add("NGUID");
            }
        }

        [Column(Name = "JSCS")]
        public System.String JSCS
        {
            get { return _JSCS; }
            set
            {
                _JSCS = value;
                cf.Add("JSCS");
            }
        }

        [Column(Name = "SJBH")]
        public System.String SJBH
        {
            get { return _SJBH; }
            set
            {
                _SJBH = value;
                cf.Add("SJBH");
            }
        }

        [Column(Name = "XH")]
        public System.Int32 XH
        {
            get { return _XH; }
            set
            {
                _XH = value;
                cf.Add("XH");
            }
        }

        [Column(Name = "HZCLHBFBDU")]
        public System.Single HZCLHBFBDU
        {
            get { return _HZCLHBFBDU; }
            set
            {
                _HZCLHBFBDU = value;
                cf.Add("HZCLHBFBDU");
            }
        }

        [Column(Name = "HZYL")]
        public System.Single HZYL
        {
            get { return _HZYL; }
            set
            {
                _HZYL = value;
                cf.Add("HZYL");
            }
        }

        [Column(Name = "DWYL")]
        public System.Single DWYL
        {
            get { return _DWYL; }
            set
            {
                _DWYL = value;
                cf.Add("DWYL");
            }
        }

        [Column(Name = "GRGBFBDSZ")]
        public System.Single GRGBFBDSZ
        {
            get { return _GRGBFBDSZ; }
            set
            {
                _GRGBFBDSZ = value;
                cf.Add("GRGBFBDSZ");
            }
        }

        [Column(Name = "GRGBFBDSY")]
        public System.Single GRGBFBDSY
        {
            get { return _GRGBFBDSY; }
            set
            {
                _GRGBFBDSY = value;
                cf.Add("GRGBFBDSY");
            }
        }

        [Column(Name = "GRGBFBDSPJZ")]
        public System.Single GRGBFBDSPJZ
        {
            get { return _GRGBFBDSPJZ; }
            set
            {
                _GRGBFBDSPJZ = value;
                cf.Add("GRGBFBDSPJZ");
            }
        }

        [Column(Name = "GRL")]
        public System.Single GRL
        {
            get { return _GRL; }
            set
            {
                _GRL = value;
                cf.Add("GRL");
            }
        }
    }
}