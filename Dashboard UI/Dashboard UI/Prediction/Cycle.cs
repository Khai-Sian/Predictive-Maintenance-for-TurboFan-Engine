using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard_UI
{
    class Cycle
    {
        /// <summary>
        /// Machine ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Current Cycle
        /// </summary>
        public int cycle { get; set; }

        /// <summary>
        /// Operation Settings
        /// </summary>
        #region 3 OpSet
        public double OpSet1 { get; set; }
        public double OpSet2 { get; set; }
        public double OpSet3 { get; set; }
        #endregion

        /// <summary>
        /// Anonymous Sensor Measurement
        /// </summary>
        #region 21 Sensor Measurements
        public double s_1 { get; set; }
        public double s_2 { get; set; }
        public double s_3 { get; set; }
        public double s_4 { get; set; }
        public double s_5 { get; set; }
        public double s_6 { get; set; }
        public double s_7 { get; set; }
        public double s_8 { get; set; }
        public double s_9 { get; set; }
        public double s_10 { get; set; }
        public double s_11 { get; set; }
        public double s_12 { get; set; }
        public double s_13 { get; set; }
        public double s_14 { get; set; }
        public double s_15 { get; set; }
        public double s_16 { get; set; }
        public double s_17 { get; set; }
        public double s_18 { get; set; }
        public double s_19 { get; set; }
        public double s_20 { get; set; }
        public double s_21 { get; set; }
        #endregion

        //Constructor
        public Cycle()
        {

        }
    }
}
