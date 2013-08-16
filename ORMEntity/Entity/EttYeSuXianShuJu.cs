using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ORM.Common;

namespace System.ORM.Entity
{
    [Serializable]
    [Table(Name = "YeSuXianShuJu")]
    public class EttYeSuXianShuJu
    {
        ChangeFields cf = new ChangeFields();
        public enum e
        {
            NGUID,
            SYCSBJ,
            SYCS,
            RTSD1,
            RTSD2,
            PJRTSD,
            HH1,
            HH2,
            HJSTZ1,
            HJSTZ2,
            HJGTZ1,
            HJGTZ2,
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
        private float _RTSD1;
        private float _RTSD2;
        private float _PJRTSD;
        private string _HH1;
        private string _HH2;
        private float _HJSTZ1;
        private float _HJSTZ2;
        private float _HJGTZ1;
        private float _HJGTZ2;
        private float _HZ1;
        private float _HZ2;
        private float _SZ1;
        private float _SZ2;
        private float _GTZ1;
        private float _GTZ2;
        private float _HSL1;
        private float _HSL2;
        private float _PJHSL;

        [Column(Name = "NGUID")]
        public string NGUID
        {
            get { return _NGUID; }
            set
            {
                _NGUID = value;
                cf.Add("NGUID");
            }
        }

        [Column(Name = "SYCSBJ")]
        public string SYCSBJ
        {
            get { return _SYCSBJ; }
            set
            {
                _SYCSBJ = value;
                cf.Add("SYCSBJ");
            }
        }

        [Column(Name = "SYCS")]
        public string SYCS
        {
            get { return _SYCS; }
            set
            {
                _SYCS = value;
                cf.Add("SYCS");
            }
        }

        [Column(Name = "RTSD1")]
        public float RTSD1
        {
            get { return _RTSD1; }
            set
            {
                _RTSD1 = value;
                cf.Add("RTSD1");
            }
        }

        [Column(Name = "RTSD2")]
        public float RTSD2
        {
            get { return _RTSD2; }
            set
            {
                _RTSD2 = value;
                cf.Add("RTSD2");
            }
        }

        [Column(Name = "PJRTSD")]
        public float PJRTSD
        {
            get { return _PJRTSD; }
            set
            {
                _PJRTSD = value;
                cf.Add("PJRTSD");
            }
        }

        [Column(Name = "HH1")]
        public string HH1
        {
            get { return _HH1; }
            set
            {
                _HH1 = value;
                cf.Add("HH1");
            }
        }

        [Column(Name = "HH2")]
        public string HH2
        {
            get { return _HH2; }
            set
            {
                _HH2 = value;
                cf.Add("HH2");
            }
        }

        [Column(Name = "HJSTZ1")]
        public float HJSTZ1
        {
            get { return _HJSTZ1; }
            set
            {
                _HJSTZ1 = value;
                cf.Add("HJSTZ1");
            }
        }

        [Column(Name = "HJSTZ2")]
        public float HJSTZ2
        {
            get { return _HJSTZ2; }
            set
            {
                _HJSTZ2 = value;
                cf.Add("HJSTZ2");
            }
        }

        [Column(Name = "HJGTZ1")]
        public float HJGTZ1
        {
            get { return _HJGTZ1; }
            set
            {
                _HJGTZ1 = value;
                cf.Add("HJGTZ1");
            }
        }

        [Column(Name = "HJGTZ2")]
        public float HJGTZ2
        {
            get { return _HJGTZ2; }
            set
            {
                _HJGTZ2 = value;
                cf.Add("HJGTZ2");
            }
        }

        [Column(Name = "HZ1")]
        public float HZ1
        {
            get { return _HZ1; }
            set
            {
                _HZ1 = value;
                cf.Add("HZ1");
            }
        }

        [Column(Name = "HZ2")]
        public float HZ2
        {
            get { return _HZ2; }
            set
            {
                _HZ2 = value;
                cf.Add("HZ2");
            }
        }

        [Column(Name = "SZ1")]
        public float SZ1
        {
            get { return _SZ1; }
            set
            {
                _SZ1 = value;
                cf.Add("SZ1");
            }
        }

        [Column(Name = "SZ2")]
        public float SZ2
        {
            get { return _SZ2; }
            set
            {
                _SZ2 = value;
                cf.Add("SZ2");
            }
        }

        [Column(Name = "GTZ1")]
        public float GTZ1
        {
            get { return _GTZ1; }
            set
            {
                _GTZ1 = value;
                cf.Add("GTZ1");
            }
        }

        [Column(Name = "GTZ2")]
        public float GTZ2
        {
            get { return _GTZ2; }
            set
            {
                _GTZ2 = value;
                cf.Add("GTZ2");
            }
        }

        [Column(Name = "HSL1")]
        public float HSL1
        {
            get { return _HSL1; }
            set
            {
                _HSL1 = value;
                cf.Add("HSL1");
            }
        }

        [Column(Name = "HSL2")]
        public float HSL2
        {
            get { return _HSL2; }
            set
            {
                _HSL2 = value;
                cf.Add("HSL2");
            }
        }

        [Column(Name = "PJHSL")]
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
