using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ORM.Common;

namespace System.ORM.Entity
{
    [Serializable]
    [Table(Name = "TG_CBR_CommonData")]
    public class EttTG_CBR_CommonData
    {
        ChangeFields cf = new ChangeFields();
        public enum e
        {
            NGUID,
            SYBH,
            SYRQ,
            CLHXSA,
            CLHXSB,
            GRGMJ,
            STTJ
        }

        private System.String _NGUID;
        private System.String _SYBH;
        private System.DateTime _SYRQ;
        private System.Single _CLHXSA;
        private System.Single _CLHXSB;
        private System.Single _GRGMJ;
        private System.Single _STTJ;

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

        [Column(Name = "SYBH")]
        public System.String SYBH
        {
            get { return _SYBH; }
            set
            {
                _SYBH = value;
                cf.Add("SYBH");
            }
        }

        [Column(Name = "SYRQ")]
        public System.DateTime SYRQ
        {
            get { return _SYRQ; }
            set
            {
                _SYRQ = value;
                cf.Add("SYRQ");
            }
        }

        [Column(Name = "CLHXSA")]
        public System.Single CLHXSA
        {
            get { return _CLHXSA; }
            set
            {
                _CLHXSA = value;
                cf.Add("CLHXSA");
            }
        }

        [Column(Name = "CLHXSB")]
        public System.Single CLHXSB
        {
            get { return _CLHXSB; }
            set
            {
                _CLHXSB = value;
                cf.Add("CLHXSB");
            }
        }

        [Column(Name = "GRGMJ")]
        public System.Single GRGMJ
        {
            get { return _GRGMJ; }
            set
            {
                _GRGMJ = value;
                cf.Add("GRGMJ");
            }
        }

        [Column(Name = "STTJ")]
        public System.Single STTJ
        {
            get { return _STTJ; }
            set
            {
                _STTJ = value;
                cf.Add("STTJ");
            }
        }
    }
}