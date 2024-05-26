using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard_UI
{
    class Model
    {
        /// <summary>
        /// Model file
        /// </summary>
        public string modelFile { get; private set; }

        /// <summary>
        /// Train set RMSE
        /// </summary>
        public double trainRMSE { get; private set; }

        /// <summary>
        /// Test set RMSE
        /// </summary>
        public double testRMSE { get; private set; }

        /// <summary>
        /// Train set R2
        /// </summary>
        public double trainR2 { get; private set; }

        /// <summary>
        /// Test set R2
        /// </summary>
        public double testR2 { get; private set; }

        //Constructor
        public Model(string file, double trainRMSE, double testRMSE, double trainR2, double testR2)
        {
            this.modelFile = file;
            this.trainRMSE = trainRMSE;
            this.testRMSE = testRMSE;
            this.trainR2 = trainR2;
            this.testR2 = testR2;
        }
    }
}
