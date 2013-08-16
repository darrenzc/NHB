using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ORM.Common;

namespace System.ORM.Entity
{
    [Serializable]
    [Table(Name = "HeHaoSheZhi")]
    public class EttHeHaoSheZhi
    {
        ChangeFields cf = new ChangeFields();
        public enum e
        { 
            HH,
            HZ
        }

        private string hH;
        private float hZ;


        [Column(Name = "HH")]
        public string HH
        {
            get { return hH; }
            set {
                hH = value;
                cf.Add("HH");
            }
        }

        [Column(Name = "HZ")]
        public float HZ
        {
            get { return hZ; }
            set {
                hZ = value;
                cf.Add("HZ");
            }
        }
    }
}
