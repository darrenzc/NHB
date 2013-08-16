using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ORM.Common;

namespace System.ORM.Entity
{
    [Serializable]
    [Table(Name = "TG_CBR_DataAverage")]
    public class EttTG_CBR_DataAverage
    {
        ChangeFields cf = new ChangeFields();
        public enum e
        {
            NGUID,
            JSCS,
            CBR,
            PZL,
            SMD,
            GMD,
            XSL,
            HSL,
            QXT
        }

        private System.String _NGUID;
        private System.String _JSCS;
        private System.Single _CBR;
        private System.Single _PZL;
        private System.Single _SMD;
        private System.Single _GMD;
        private System.Single _XSL;
        private System.Single _HSL;
        private System.String _QXT;

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

        [Column(Name = "CBR")]
        public System.Single CBR
        {
            get { return _CBR; }
            set
            {
                _CBR = value;
                cf.Add("CBR");
            }
        }

        [Column(Name = "PZL")]
        public System.Single PZL
        {
            get { return _PZL; }
            set
            {
                _PZL = value;
                cf.Add("PZL");
            }
        }

        [Column(Name = "SMD")]
        public System.Single SMD
        {
            get { return _SMD; }
            set
            {
                _SMD = value;
                cf.Add("SMD");
            }
        }

        [Column(Name = "GMD")]
        public System.Single GMD
        {
            get { return _GMD; }
            set
            {
                _GMD = value;
                cf.Add("GMD");
            }
        }

        [Column(Name = "XSL")]
        public System.Single XSL
        {
            get { return _XSL; }
            set
            {
                _XSL = value;
                cf.Add("XSL");
            }
        }

        [Column(Name = "HSL")]
        public System.Single HSL
        {
            get { return _HSL; }
            set
            {
                _HSL = value;
                cf.Add("HSL");
            }
        }

        [Column(Name = "QXT")]
        public System.String QXT
        {
            get { return _QXT; }
            set
            {
                _QXT = value;
                cf.Add("QXT");
            }
        }
    }
}