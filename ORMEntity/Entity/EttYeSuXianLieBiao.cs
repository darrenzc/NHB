using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ORM.Common;

namespace System.ORM.Entity
{
    [Serializable]
    [Table(Name = "YeSuXianLieBiao")]
    public class EttYeSuXianLieBiao
    {
        ChangeFields cf = new ChangeFields();
        public enum e
        {
            NGUID,
            WTID,
            SYBH,
            YPBS,
            JL,
            BZ,
            BGRQ,
            SYRQ,
            YX1,
            SX1,
            SXZS1,
            QXT1,
            YX2,
            SX2,
            SXZS2,
            QXT2,
            TRZL,
            SYJLZT,
            SYBGFY,
            ZYSYSBBH,
            SYFF,
            SYXM,
            YXJZ,
            SXJZ,
            SXZSJZ,
            YZZL,
            JCYJ

        }

         private string _NGUID;
         private string _WTID;
         private string _SYBH;
         private string _YPBS;
         private string _JL;
         private string _BZ;
         private DateTime _BGRQ;
         private DateTime _SYRQ;
         private float _YX1;
         private float _SX1;
         private float _SXZS1;
         private string _QXT1;
         private float _YX2;
         private float _SX2;
         private float _SXZS2;
         private string _QXT2;
         private string _TRZL;
         private string _SYJLZT;
         private float _SYBGFY;
         private string _ZYSYSBBH;
         private string _SYFF;
         private string _SYXM;
         private float _YXJZ;
         private float _SXJZ;
         private float _SXZSJZ;
         private string _YZZL;
         private string _JCYJ;

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

        [Column(Name = "WTID")]
        public string WTID
        {
            get { return _WTID; }
            set
            {
                _WTID = value;
                cf.Add("WTID");
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

        [Column(Name = "YPBS")]
        public string YPBS
        {
            get { return _YPBS; }
            set
            {
                _YPBS = value;
                cf.Add("YPBS");
            }
        }

        [Column(Name = "JL")]
        public string JL
        {
            get { return _JL; }
            set
            {
                _JL = value;
                cf.Add("JL");
            }
        }

        [Column(Name = "BZ")]
        public string BZ
        {
            get { return _BZ; }
            set
            {
                _BZ = value;
                cf.Add("BZ");
            }
        }

        [Column(Name = "BGRQ")]
        public DateTime BGRQ
        {
            get { return _BGRQ; }
            set
            {
                _BGRQ = value;
                cf.Add("BGRQ");
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

        [Column(Name = "YX1")]
        public float YX1
        {
            get { return _YX1; }
            set
            {
                _YX1 = value;
                cf.Add("YX1");
            }
        }

        [Column(Name = "SX1")]
        public float SX1
        {
            get { return _SX1; }
            set
            {
                _SX1 = value;
                cf.Add("SX1");
            }
        }

        [Column(Name = "SXZS1")]
        public float SXZS1
        {
            get { return _SXZS1; }
            set
            {
                _SXZS1 = value;
                cf.Add("SXZS1");
            }
        }

        [Column(Name = "QXT1")]
        public string QXT1
        {
            get { return _QXT1; }
            set
            {
                _QXT1 = value;
                cf.Add("QXT1");
            }
        }

        [Column(Name = "YX2")]
        public float YX2
        {
            get { return _YX2; }
            set
            {
                _YX2 = value;
                cf.Add("YX2");
            }
        }

        [Column(Name = "SX2")]
        public float SX2
        {
            get { return _SX2; }
            set
            {
                _SX2 = value;
                cf.Add("SX2");
            }
        }

        [Column(Name = "SXZS2")]
        public float SXZS2
        {
            get { return _SXZS2; }
            set
            {
                _SXZS2 = value;
                cf.Add("SXZS2");
            }
        }

        [Column(Name = "QXT2")]
        public string QXT2
        {
            get { return _QXT2; }
            set
            {
                _QXT2 = value;
                cf.Add("QXT2");
            }
        }

        [Column(Name = "TRZL")]
        public string TRZL
        {
            get { return _TRZL; }
            set
            {
                _TRZL = value;
                cf.Add("TRZL");
            }
        }

        [Column(Name = "SYJLZT")]
        public string SYJLZT
        {
            get { return _SYJLZT; }
            set
            {
                _SYJLZT = value;
                cf.Add("SYJLZT");
            }
        }

        [Column(Name = "SYBGFY")]
        public float SYBGFY
        {
            get { return _SYBGFY; }
            set
            {
                _SYBGFY = value;
                cf.Add("SYBGFY");
            }
        }

        [Column(Name = "ZYSYSBBH")]
        public string ZYSYSBBH
        {
            get { return _ZYSYSBBH; }
            set
            {
                _ZYSYSBBH = value;
                cf.Add("ZYSYSBBH");
            }
        }

        [Column(Name = "SYFF")]
        public string SYFF
        {
            get { return _SYFF; }
            set
            {
                _SYFF = value;
                cf.Add("SYFF");
            }
        }

        [Column(Name = "SYXM")]
        public string SYXM
        {
            get { return _SYXM; }
            set
            {
                _SYXM = value;
                cf.Add("SYXM");
            }
        }

        [Column(Name = "YXJZ")]
        public float YXJZ
        {
            get { return _YXJZ; }
            set
            {
                _YXJZ = value;
                cf.Add("YXJZ");
            }
        }

        [Column(Name = "SXJZ")]
        public float SXJZ
        {
            get { return _SXJZ; }
            set
            {
                _SXJZ = value;
                cf.Add("SXJZ");
            }
        }

        [Column(Name = "SXZSJZ")]
        public float SXZSJZ
        {
            get { return _SXZSJZ; }
            set
            {
                _SXZSJZ = value;
                cf.Add("SXZSJZ");
            }
        }

        [Column(Name = "YZZL")]
        public string YZZL
        {
            get { return _YZZL; }
            set
            {
                _YZZL = value;
                cf.Add("YZZL");
            }
        }

        [Column(Name = "JCYJ")]
        public string JCYJ
        {
            get { return _JCYJ; }
            set
            {
                _JCYJ = value;
                cf.Add("JCYJ");
            }
        }

    }
}
