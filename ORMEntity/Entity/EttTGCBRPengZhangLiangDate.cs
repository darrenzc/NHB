using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ORM.Common;

namespace System.ORM.Entity
{
    [Serializable]
    [Table(Name = "TGCBRPengZhangLiangDate")]
    public class EttTGCBRPengZhangLiangDate
    {
        public enum e
        {
            GUID,
            SYCSBJ,
            SYCS,
            JSCS,
            SJBH,
            HH,
            HSTZ,
            HGTZ,
            HZ,
            SZ,
            GTZ,
            HSL,
            PJHSL,
            JSQSTHSJHJZL,
            JSHSTHSJHJZL,
            JSQSJGD,
            JSHSJGD,
            PZL,
            SMD,
            GMD,
            XSL,
            STZL
        }

        [Column(Name = "GUID")]
        public string GUID { get; set; }

        [Column(Name = "SYCSBJ")]
        public string SYCSBJ { get; set; }

        [Column(Name = "SYCS")]
        public string SYCS { get; set; }

        [Column(Name = "JSCS")]
        public string JSCS { get; set; }

        [Column(Name = "SJBH")]
        public string SJBH { get; set; }

        [Column(Name = "HH")]
        public string HH { get; set; }

        [Column(Name = "HSTZ")]
        public float HSTZ { get; set; }

        [Column(Name = "HGTZ")]
        public float HGTZ { get; set; }

        [Column(Name = "HZ")]
        public float HZ { get; set; }

        [Column(Name = "SZ")]
        public float SZ { get; set; }

        [Column(Name = "GTZ")]
        public float GTZ { get; set; }

        [Column(Name = "HSL")]
        public float HSL { get; set; }

        [Column(Name = "PJHSL")]
        public float PJHSL { get; set; }

        [Column(Name = "JSQSTHSJHJZL")]
        public float JSQSTHSJHJZL { get; set; }

        [Column(Name = "JSHSTHSJHJZL")]
        public float JSHSTHSJHJZL { get; set; }

        [Column(Name = "JSQSJGD")]
        public float JSQSJGD { get; set; }

        [Column(Name = "JSHSJGD")]
        public float JSHSJGD { get; set; }

        [Column(Name = "PZL")]
        public float PZL { get; set; }

        [Column(Name = "SMD")]
        public float SMD { get; set; }

        [Column(Name = "GMD")]
        public float GMD { get; set; }

        [Column(Name = "XSL")]
        public float XSL { get; set; }

        [Column(Name = "STZL")]
        public float STZL { get; set; }
    }
    
}