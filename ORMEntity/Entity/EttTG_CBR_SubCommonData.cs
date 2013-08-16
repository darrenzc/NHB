using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ORM.Common;

namespace System.ORM.Entity
{
    [Serializable]
    [Table(Name = "TG_CBR_SubCommonData")]
    public class EttTG_CBR_SubCommonData
    {
        ChangeFields cf = new ChangeFields();
        public enum e
        {
            NGUID,
            JSCS,
            SJBH,
            HH1,
            HH2,
            HSTZ1,
            HSTZ2,
            HGTZ1,
            HGTZ2,
            HZ1,
            HZ2,
            SZ1,
            SZ2,
            GTZ1,
            GTZ2,
            HSL1,
            HSL2,
            PJHSL,
            JSQSTHSJHJZL,
            JSHSTHSJHJZL,
            JSQSJGD,
            JSHSJGD,
            PZL,
            SMD,
            GMD,
            XSL,
            STZL,
            CBR,
            CBR25,
            CBR50,
            QXT
        }

        private System.String _NGUID;
        private System.String _JSCS;
        private System.String _SJBH;
        private System.String _HH1;
        private System.String _HH2;
        private System.Single _HSTZ1;
        private System.Single _HSTZ2;
        private System.Single _HGTZ1;
        private System.Single _HGTZ2;
        private System.Single _HZ1;
        private System.Single _HZ2;
        private System.Single _SZ1;
        private System.Single _SZ2;
        private System.Single _GTZ1;
        private System.Int32 _GTZ2;
        private System.Single _HSL1;
        private System.Single _HSL2;
        private System.Single _PJHSL;
        private System.Single _JSQSTHSJHJZL;
        private System.Single _JSHSTHSJHJZL;
        private System.Single _JSQSJGD;
        private System.Single _JSHSJGD;
        private System.Single _PZL;
        private System.Single _SMD;
        private System.Single _GMD;
        private System.Single _XSL;
        private System.Single _STZL;
        private System.Single _CBR;
        private System.Single _CBR25;
        private System.Single _CBR50;
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

        [Column(Name = "HH1")]
        public System.String HH1
        {
            get { return _HH1; }
            set
            {
                _HH1 = value;
                cf.Add("HH1");
            }
        }

        [Column(Name = "HH2")]
        public System.String HH2
        {
            get { return _HH2; }
            set
            {
                _HH2 = value;
                cf.Add("HH2");
            }
        }

        [Column(Name = "HSTZ1")]
        public System.Single HSTZ1
        {
            get { return _HSTZ1; }
            set
            {
                _HSTZ1 = value;
                cf.Add("HSTZ1");
            }
        }

        [Column(Name = "HSTZ2")]
        public System.Single HSTZ2
        {
            get { return _HSTZ2; }
            set
            {
                _HSTZ2 = value;
                cf.Add("HSTZ2");
            }
        }

        [Column(Name = "HGTZ1")]
        public System.Single HGTZ1
        {
            get { return _HGTZ1; }
            set
            {
                _HGTZ1 = value;
                cf.Add("HGTZ1");
            }
        }

        [Column(Name = "HGTZ2")]
        public System.Single HGTZ2
        {
            get { return _HGTZ2; }
            set
            {
                _HGTZ2 = value;
                cf.Add("HGTZ2");
            }
        }

        [Column(Name = "HZ1")]
        public System.Single HZ1
        {
            get { return _HZ1; }
            set
            {
                _HZ1 = value;
                cf.Add("HZ1");
            }
        }

        [Column(Name = "HZ2")]
        public System.Single HZ2
        {
            get { return _HZ2; }
            set
            {
                _HZ2 = value;
                cf.Add("HZ2");
            }
        }

        [Column(Name = "SZ1")]
        public System.Single SZ1
        {
            get { return _SZ1; }
            set
            {
                _SZ1 = value;
                cf.Add("SZ1");
            }
        }

        [Column(Name = "SZ2")]
        public System.Single SZ2
        {
            get { return _SZ2; }
            set
            {
                _SZ2 = value;
                cf.Add("SZ2");
            }
        }

        [Column(Name = "GTZ1")]
        public System.Single GTZ1
        {
            get { return _GTZ1; }
            set
            {
                _GTZ1 = value;
                cf.Add("GTZ1");
            }
        }

        [Column(Name = "GTZ2")]
        public System.Int32 GTZ2
        {
            get { return _GTZ2; }
            set
            {
                _GTZ2 = value;
                cf.Add("GTZ2");
            }
        }

        [Column(Name = "HSL1")]
        public System.Single HSL1
        {
            get { return _HSL1; }
            set
            {
                _HSL1 = value;
                cf.Add("HSL1");
            }
        }

        [Column(Name = "HSL2")]
        public System.Single HSL2
        {
            get { return _HSL2; }
            set
            {
                _HSL2 = value;
                cf.Add("HSL2");
            }
        }

        [Column(Name = "PJHSL")]
        public System.Single PJHSL
        {
            get { return _PJHSL; }
            set
            {
                _PJHSL = value;
                cf.Add("PJHSL");
            }
        }

        [Column(Name = "JSQSTHSJHJZL")]
        public System.Single JSQSTHSJHJZL
        {
            get { return _JSQSTHSJHJZL; }
            set
            {
                _JSQSTHSJHJZL = value;
                cf.Add("JSQSTHSJHJZL");
            }
        }

        [Column(Name = "JSHSTHSJHJZL")]
        public System.Single JSHSTHSJHJZL
        {
            get { return _JSHSTHSJHJZL; }
            set
            {
                _JSHSTHSJHJZL = value;
                cf.Add("JSHSTHSJHJZL");
            }
        }

        [Column(Name = "JSQSJGD")]
        public System.Single JSQSJGD
        {
            get { return _JSQSJGD; }
            set
            {
                _JSQSJGD = value;
                cf.Add("JSQSJGD");
            }
        }

        [Column(Name = "JSHSJGD")]
        public System.Single JSHSJGD
        {
            get { return _JSHSJGD; }
            set
            {
                _JSHSJGD = value;
                cf.Add("JSHSJGD");
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

        [Column(Name = "STZL")]
        public System.Single STZL
        {
            get { return _STZL; }
            set
            {
                _STZL = value;
                cf.Add("STZL");
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

        [Column(Name = "CBR25")]
        public System.Single CBR25
        {
            get { return _CBR25; }
            set
            {
                _CBR25 = value;
                cf.Add("CBR25");
            }
        }

        [Column(Name = "CBR50")]
        public System.Single CBR50
        {
            get { return _CBR50; }
            set
            {
                _CBR50 = value;
                cf.Add("CBR50");
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