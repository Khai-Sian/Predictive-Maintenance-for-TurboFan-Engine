using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_UI
{
    public partial class ModelForm : Form
    {
        ArrayList modelList = new ArrayList();
        public static string currentModelFile;

        public ModelForm()
        {
            InitializeComponent();

            //predictive model
            Model basemodel = new Model(Environment.CurrentDirectory + @"\model\base_model.sav", 44.66, 31.95, 0.58, 0.41);
            Model linearRegression = new Model(Environment.CurrentDirectory + @"\model\linear_model.sav", 21.51, 21.90, 0.73, 0.72);
            Model PolynomialRegression = new Model(Environment.CurrentDirectory + @"\model\polynomial_model.sav", 18.06, 18.42, 0.81, 0.80);
            Model SupportVector = new Model(Environment.CurrentDirectory + @"\model\SVR_model.sav", 18.13, 18.38, 0.81, 0.80);
            Model RandomForest = new Model(Environment.CurrentDirectory + @"\model\RFR_model.sav", 16.51, 17.68, 0.84, 0.82);
            Model GBR = new Model(Environment.CurrentDirectory + @"\model\GBR_model.sav", 17.29, 17.34, 0.83, 0.83);

            modelList.Add(basemodel);
            modelList.Add(linearRegression);
            modelList.Add(PolynomialRegression);
            modelList.Add(SupportVector);
            modelList.Add(RandomForest);
            modelList.Add(GBR);

            string[] modelsName = { "BaseLine Model", "Linear Regression", "Polynomial Regression", "Support Vector Regression", "Random Forest", "Gradient Boosting Regression"};

            //add model to drop down menu
            ModelList.DataSource = modelsName;
            ModelList.SelectedItem = "Gradient Boosting Regression";
        }

        /// <summary>
        /// when drop down menu index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model currentModel = (Model)modelList[ModelList.SelectedIndex];
            currentModelFile = currentModel.modelFile; //get model fiel path

            if(EngineForm.machineList != null)
            {
                EngineForm.form2.MachineList_SelectedIndexChanged(EngineForm.machineList, new EventArgs()); //update engine using selected model
            }

            //display performance matrix
            TrainRMSEMeasure.Text = currentModel.trainRMSE.ToString();
            TestRMSEMeasure.Text = currentModel.testRMSE.ToString();
            TrainR2Measure.Text = currentModel.trainR2.ToString();
            TestR2Measure.Text = currentModel.testR2.ToString();
        }
    }
}
