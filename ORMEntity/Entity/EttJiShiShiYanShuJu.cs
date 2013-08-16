using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ORM.Common;

namespace System.ORM.Entity
{
    [Serializable]
    [Table(Name = "JiShiShiYanShuJu")]
    public class EttJiShiShiYanShuJu
    {
        ChangeFields cf = new ChangeFields();
        public enum e
        { 
            NGUID,
            SYCSBJ,
            SYCS,
            TJSTZ,
            TZ,
            STZ,
            SMD,
            GMD,
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
            PJHSL
        }

        private string _NGUID;
        private string _SYCSBJ;
        private string _SYCS;
        private float _TJSTZ;
        private float _TZ;
        private float _STZ;
        private float _SMD;
        private float _GMD;
        private string _HH1;
        private string _HH2;
        private float _HSTZ1;
        private float _HSTZ2;
        private float _HGTZ1;
        private float _HGTZ2;
        private float _HZ1;
        private float _HZ2;
        private float _SZ1;
        private float _SZ2;
        private float _GTZ1;
        private float _GTZ2;
        private float _HSL1;
        private float _HSL2;
        private float _PJHSL;

        [Column(Name="NGUID")]
        public string NGUID
        {
            get { return _NGUID; }
            set
            { 
                _NGUID =value;
                cf.Add("NGUID");
            }
        }

        [Column(Name="SYCSBJ")]
        public string SYCSBJ
        {
            get { return _SYCSBJ; }
            set
            { 
                _SYCSBJ =value;
                cf.Add("SYCSBJ");
            }
        }

        [Column(Name="SYCS")]
        public string SYCS
        {
            get { return _SYCS; }
            set
            { 
                _SYCS =value;
                cf.Add("SYCS");
            }
        }

        [Column(Name="TJSTZ")]
        public float TJSTZ
        {
            get { return _TJSTZ; }
            set
            { 
                _TJSTZ=value;
                cf.Add("TJSTZ");
            }
        }

        [Column(Name="TZ")]
        public float TZ
        {
            get { return _TZ; }
            set
            { 
                _TZ=value;
                cf.Add("TZ");
            }
        }

        [Column(Name="STZ")]
        public float STZ
        {
            get { return _STZ; }
            set
            { 
                _STZ=value;
                cf.Add("STZ");
            }
        }

        [Column(Name="SMD")]
        public float SMD
        {
            get { return _SMD; }
            set
            { 
                _SMD=value;
                cf.Add("SMD");
            }
        }

        [Column(Name="GMD")]
        public float GMD
        {
            get { return _GMD; }
            set
            { 
                _GMD=value;
                cf.Add("GMD");
            }
        }

        [Column(Name="HH1")]
        public string HH1
        {
            get { return _HH1; }
            set
            { 
                _HH1=value;
                cf.Add("HH1");
            }
        }

        [Column(Name="HH2")]
        public string HH2
        {
            get { return _HH2; }
            set
            { 
                _HH2=value;
                cf.Add("HH2");
            }
        }

        [Column(Name="HSTZ1")]
        public float HSTZ1
        {
            get { return _HSTZ1; }
            set
            { 
                _HSTZ1=value;
                cf.Add("HSTZ1");
            }
        }

        [Column(Name="HSTZ2")]
        public float HSTZ2
        {
            get { return _HSTZ2; }
            set
            { 
                _HSTZ2 =value;
                cf.Add("HSTZ2");
            }
        }

        [Column(Name="HGTZ1")]
        public float HGTZ1
        {
            get { return _HGTZ1; }
            set
            { 
                _HGTZ1=value;
                cf.Add("HGTZ1");
            }
        }

        [Column(Name="HGTZ2")]
        public float HGTZ2
        {
            get { return _HGTZ2; }
            set
            { 
                _HGTZ2=value;
                cf.Add("HGTZ2");
            }
        }

        [Column(Name="HZ1")]
        public float HZ1
        {
            get { return _HZ1; }
            set
            { 
                _HZ1=value;
                cf.Add("HZ1");
            }
        }

        [Column(Name="HZ2")]
        public float HZ2
        {
            get { return _HZ2; }
            set
            {
                _HZ2 = value;
                cf.Add("HZ2");
            }
        }

        [Column(Name="SZ1")]
        public float SZ1
        {
            get { return _SZ1; }
            set
            {
                _SZ1 = value;
                cf.Add("SZ1");
            }
        }

        [Column(Name="SZ2")]
        public float SZ2
        {
            get { return _SZ2; }
            set
            {
                _SZ2 = value;
                cf.Add("SZ2");
            }
        }

        [Column(Name="GTZ1")]
        public float GTZ1
        {
            get { return _GTZ1; }
            set
            {
                _GTZ1 = value;
                cf.Add("GTZ1");
            }
        }

        [Column(Name="GTZ2")]
        public float GTZ2
        {
            get { return _GTZ2; }
            set
            {
                _GTZ2 = value;
                cf.Add("GTZ2");
            }
        }

        [Column(Name="HSL1")]
        public float HSL1
        {
            get { return _HSL1; }
            set
            {
                _HSL1 = value;
                cf.Add("HSL1");
            }
        }

        [Column(Name="HSL2")]
        public float HSL2
        {
            get { return _HSL2; }
            set
            {
                _HSL2 = value;
                cf.Add("HSL2");
            }
        }

        [Column(Name="PJHSL")]
        public float PJHSL
        {
            get { return _PJHSL; }
            set
            {
                _PJHSL = value;
                cf.Add("PJHSL");
            }
        }
    }
}
