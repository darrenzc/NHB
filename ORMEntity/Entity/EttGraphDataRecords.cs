using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ORM.Common;

namespace System.ORM.Entity
{
    [Serializable]
    [Table(Name = "GraphDataRecords")]
    public class EttGraphDataRecords
    {
        ChangeFields cf = new ChangeFields();
        public enum e
        {
            NGUID,
            CTLNAME,
            AOCINDEX,
            QXTPointsAoc,
            QXTLinesAoc,
            titleBottom,
            manualSetX,
            manualSetY,
            aocX,
            aocY,
            startValueX,
            startValueY,
            maxValueX,
            maxValueY,
            stepX,
            stepY,
            gray,
            lineDes
        }

        private System.String _NGUID;
        private System.String _CTLNAME;
        private System.Int32 _AOCINDEX;
        private System.String _QXTPointsAoc;
        private System.String _QXTLinesAoc;
        private System.Boolean _titleBottom;
        private System.Boolean _manualSetX;
        private System.Boolean _manualSetY;
        private System.String _aocX;
        private System.String _aocY;
        private System.Single _startValueX;
        private System.Single _startValueY;
        private System.Single _maxValueX;
        private System.Single _maxValueY;
        private System.Single _stepX;
        private System.Single _stepY;
        private System.Boolean _gray;
        private System.Boolean _lineDes;

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

        [Column(Name = "CTLNAME")]
        public System.String CTLNAME
        {
            get { return _CTLNAME; }
            set
            {
                _CTLNAME = value;
                cf.Add("CTLNAME");
            }
        }

        [Column(Name = "AOCINDEX")]
        public System.Int32 AOCINDEX
        {
            get { return _AOCINDEX; }
            set
            {
                _AOCINDEX = value;
                cf.Add("AOCINDEX");
            }
        }

        [Column(Name = "QXTPointsAoc")]
        public System.String QXTPointsAoc
        {
            get { return _QXTPointsAoc; }
            set
            {
                _QXTPointsAoc = value;
                cf.Add("QXTPointsAoc");
            }
        }

        [Column(Name = "QXTLinesAoc")]
        public System.String QXTLinesAoc
        {
            get { return _QXTLinesAoc; }
            set
            {
                _QXTLinesAoc = value;
                cf.Add("QXTLinesAoc");
            }
        }

        [Column(Name = "titleBottom")]
        public System.Boolean titleBottom
        {
            get { return _titleBottom; }
            set
            {
                _titleBottom = value;
                cf.Add("titleBottom");
            }
        }

        [Column(Name = "manualSetX")]
        public System.Boolean manualSetX
        {
            get { return _manualSetX; }
            set
            {
                _manualSetX = value;
                cf.Add("manualSetX");
            }
        }

        [Column(Name = "manualSetY")]
        public System.Boolean manualSetY
        {
            get { return _manualSetY; }
            set
            {
                _manualSetY = value;
                cf.Add("manualSetY");
            }
        }

        [Column(Name = "aocX")]
        public System.String aocX
        {
            get { return _aocX; }
            set
            {
                _aocX = value;
                cf.Add("aocX");
            }
        }

        [Column(Name = "aocY")]
        public System.String aocY
        {
            get { return _aocY; }
            set
            {
                _aocY = value;
                cf.Add("aocY");
            }
        }

        [Column(Name = "startValueX")]
        public System.Single startValueX
        {
            get { return _startValueX; }
            set
            {
                _startValueX = value;
                cf.Add("startValueX");
            }
        }

        [Column(Name = "startValueY")]
        public System.Single startValueY
        {
            get { return _startValueY; }
            set
            {
                _startValueY = value;
                cf.Add("startValueY");
            }
        }

        [Column(Name = "maxValueX")]
        public System.Single maxValueX
        {
            get { return _maxValueX; }
            set
            {
                _maxValueX = value;
                cf.Add("maxValueX");
            }
        }

        [Column(Name = "maxValueY")]
        public System.Single maxValueY
        {
            get { return _maxValueY; }
            set
            {
                _maxValueY = value;
                cf.Add("maxValueY");
            }
        }

        [Column(Name = "stepX")]
        public System.Single stepX
        {
            get { return _stepX; }
            set
            {
                _stepX = value;
                cf.Add("stepX");
            }
        }

        [Column(Name = "stepY")]
        public System.Single stepY
        {
            get { return _stepY; }
            set
            {
                _stepY = value;
                cf.Add("stepY");
            }
        }

        [Column(Name = "gray")]
        public System.Boolean gray
        {
            get { return _gray; }
            set
            {
                _gray = value;
                cf.Add("gray");
            }
        }

        [Column(Name = "lineDes")]
        public System.Boolean lineDes
        {
            get { return _lineDes; }
            set
            {
                _lineDes = value;
                cf.Add("lineDes");
            }
        }
    }
}