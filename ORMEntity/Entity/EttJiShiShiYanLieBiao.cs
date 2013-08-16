using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ORM.Common;

namespace System.ORM.Entity
{
    [Serializable]
    [Table(Name = "JiShiShiYanLieBiao")]
    public class EttJiShiShiYanLieBiao
    {
        ChangeFields cf = new ChangeFields();
        public enum e
        {
            NGUID,
            SYCSBJ,
            SYBZ,
            ZDLJ,
            CCCKLBFL,
            CCCLJMTJXDMD,
            CCCLJXSL,
            ZJHSL,
            ZDGMD,
            JSCS,
            STTJ,
            HSLPXCD,
            JZHHT,
            QXT,
            SYBH,
            SYRQ
        }

        private string _NGUID;
        private string _SYCSBJ;
        private float _SYBZ;
        private string _ZDLJ;
        private float _CCCKLBFL;
        private float _CCCLJMTJXDMD;
        private float _CCCLJXSL;
        private float _ZJHSL;
        private float _ZDGMD;
        private string _JSCS;
        private float _STTJ;
        private bool _HSLPXCD;
        private bool _JZHHT;
        private string _QXT;
        private string _SYBH;
        private DateTime _SYRQ;

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

        [Column(Name = "SYBZ")]
        public float SYBZ
        {
            get { return _SYBZ; }
            set
            {
                _SYBZ = value;
                cf.Add("SYBZ");
            }
        }

        [Column(Name = "ZDLJ")]
        public string ZDLJ
        {
            get { return _ZDLJ; }
            set
            {
                _ZDLJ = value;
                cf.Add("ZDLJ");
            }
        }

        [Column(Name = "CCCKLBFL")]
        public float CCCKLBFL
        {
            get { return _CCCKLBFL; }
            set
            {
                _CCCKLBFL = value;
                cf.Add("CCCKLBFL");
            }
        }

        [Column(Name = "CCCLJMTJXDMD")]
        public float CCCLJMTJXDMD
        {
            get { return _CCCLJMTJXDMD; }
            set
            {
                _CCCLJMTJXDMD = value;
                cf.Add("CCCLJMTJXDMD");
            }
        }

        [Column(Name = "CCCLJXSL")]
        public float CCCLJXSL
        {
            get { return _CCCLJXSL; }
            set
            {
                _CCCLJXSL = value;
                cf.Add("CCCLJXSL");
            }
        }

        [Column(Name = "ZJHSL")]
        public float ZJHSL
        {
            get { return _ZJHSL; }
            set
            {
                _ZJHSL = value;
                cf.Add("ZJHSL");
            }
        }

        [Column(Name = "ZDGMD")]
        public float ZDGMD
        {
            get { return _ZDGMD; }
            set
            {
                _ZDGMD = value;
                cf.Add("ZDGMD");
            }
        }

        [Column(Name = "JSCS")]
        public string JSCS
        {
            get { return _JSCS; }
            set
            {
                _JSCS = value;
                cf.Add("JSCS");
            }
        }

        [Column(Name = "STTJ")]
        public float STTJ
        {
            get { return _STTJ; }
            set
            {
                _STTJ = value;
                cf.Add("STTJ");
            }
        }

        [Column(Name = "HSLPXCD")]
        public bool HSLPXCD
        {
            get { return _HSLPXCD; }
            set
            {
                _HSLPXCD = value;
                cf.Add("HSLPXCD");
            }
        }

        [Column(Name = "JZHHT")]
        public bool JZHHT
        {
            get { return _JZHHT; }
            set
            {
                _JZHHT = value;
                cf.Add("JZHHT");
            }
        }

        [Column(Name = "QXT")]
        public string QXT
        {
            get { return _QXT; }
            set
            {
                _QXT = value;
                cf.Add("QXT");
            }
        }

        [Column(Name = "SYBH")]
        public string SYBH
        {
            get { return _SYBH; }
            set
            {
                _SYBH = value;
                cf.Add("SYBH");
            }
        }

        [Column(Name = "SYRQ")]
        public DateTime SYRQ
        {
            get { return _SYRQ; }
            set
            {
                _SYRQ = value;
                cf.Add("SYRQ");
            }
        }
    }
}
