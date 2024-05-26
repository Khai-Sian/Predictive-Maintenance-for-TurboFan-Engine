using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Dashboard_UI
{
    public partial class EngineForm : Form
    {
        public static ComboBox machineList;
        public static EngineForm form2;

        readonly System.Windows.Forms.Timer SQLtimer = new System.Windows.Forms.Timer();

        private Panel loadingPanel = null;
        private PictureBox loadingBox = null;
        private int machineID = 0;
        private string modelFile;

        //get information from configuration file
        private string pythonFile = ConfigurationManager.AppSettings["PythonFile"];
        private string scriptFile = Path.Combine(Environment.CurrentDirectory, ConfigurationManager.AppSettings["ScriptFile"]);
        private int MachineNum = int.Parse(ConfigurationManager.AppSettings["MachineNum"]);
        private string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        public EngineForm()
        {
            InitializeComponent();
            form2 = this;
            machineList = MachineList;

            #region Loading Page
            //create loading panel
            if (loadingPanel != null || loadingBox != null)
            {
                loadingPanel.Dispose();
                loadingBox.Dispose();
            }
            //set panel properties
            loadingPanel = new Panel();
            loadingPanel.Size = new Size(Container.Width, Container.Height);
            loadingPanel.Dock = DockStyle.Fill;
            loadingPanel.Padding = new Padding(250, 250, 250, 250);
            loadingPanel.BackColor = Color.FromArgb(30, 31, 44);

            //add image to panel
            loadingBox = new PictureBox();
            loadingBox.Dock = DockStyle.Fill;
            loadingBox.SizeMode = PictureBoxSizeMode.Zoom;
            loadingBox.Image = Properties.Resources.Loading;
            loadingBox.Visible = true;
            loadingPanel.Controls.Add(loadingBox);
            loadingPanel.Controls.SetChildIndex(loadingBox, 0);

            //add panel to parent panel
            Container.Controls.Add(loadingPanel);
            Container.Controls.SetChildIndex(loadingPanel, 0);
            Container.Tag = loadingPanel;

            loadingPanel.BringToFront();

            TopPanel.Visible = false;
            BottomPanel.Visible = false;
            loadingPanel.Visible = true;
            #endregion

            //add engines to drop down menu
            for (int i = 1; i <= MachineNum; i++)
            {
                MachineList.Items.Add("Turbo Fan " + i);
            }
            MachineList.SelectedIndex = 0;

            //set timer to update data
            SQLtimer.Interval = (5 * 60 * 1000);
            SQLtimer.Tick += updateData;
            SQLtimer.Enabled = true;
        }

        /// <summary>
        /// task to get engine data
        /// </summary>
        /// <returns></returns>
        private async Task showMachine()
        {
            machineID = MachineList.SelectedIndex + 1; //selected engine ID
            modelFile = ModelForm.currentModelFile; //selected model

            await Task.Run(() =>
            {
                Cycle machineCycle = getCycle(machineID); //get last cycle of engine

                int RUL = getRUL(modelFile, machineCycle); //predict RUL of engine

                this.Invoke(new MethodInvoker(delegate ()
                {
                    //display value
                    #region show value
                    CycleMeasure.Text = machineCycle.cycle.ToString();
                    Setting1Measure.Text = machineCycle.OpSet1.ToString();
                    Setting2Measure.Text = machineCycle.OpSet2.ToString();
                    Setting3Measure.Text = machineCycle.OpSet3.ToString();
                    Sensor1Measure.Text = machineCycle.s_1.ToString();
                    Sensor2Measure.Text = machineCycle.s_2.ToString();
                    Sensor3Measure.Text = machineCycle.s_3.ToString();
                    Sensor4Measure.Text = machineCycle.s_4.ToString();
                    Sensor5Measure.Text = machineCycle.s_5.ToString();
                    Sensor6Measure.Text = machineCycle.s_6.ToString();
                    Sensor7Measure.Text = machineCycle.s_7.ToString();
                    Sensor8Measure.Text = machineCycle.s_8.ToString();
                    Sensor9Measure.Text = machineCycle.s_9.ToString();
                    Sensor10Measure.Text = machineCycle.s_10.ToString();
                    Sensor11Measure.Text = machineCycle.s_11.ToString();
                    Sensor12Measure.Text = machineCycle.s_12.ToString();
                    Sensor13Measure.Text = machineCycle.s_13.ToString();
                    Sensor14Measure.Text = machineCycle.s_14.ToString();
                    Sensor15Measure.Text = machineCycle.s_15.ToString();
                    Sensor16Measure.Text = machineCycle.s_16.ToString();
                    Sensor17Measure.Text = machineCycle.s_17.ToString();
                    Sensor18Measure.Text = machineCycle.s_18.ToString();
                    Sensor19Measure.Text = machineCycle.s_19.ToString();
                    Sensor20Measure.Text = machineCycle.s_20.ToString();
                    Sensor21Measure.Text = machineCycle.s_21.ToString();
                    RULMeasure.Text = RUL.ToString();
                    #endregion
                }));
                
            });
        }

        /// <summary>
        /// predict RUL of engine
        /// </summary>
        /// <param name="modelFile"></param>
        /// <param name="machineCycle"></param>
        /// <returns></returns>
        private int getRUL(string modelFile, Cycle machineCycle)
        {
            Predictor b = new Predictor(pythonFile, scriptFile); //create predictor

            double output = b.prediction(modelFile, machineCycle); //perform prediction
            int result = Convert.ToInt32(output);

            return result;
        }

        /// <summary>
        /// get last cycle of engine
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        private Cycle getCycle(int ID)
        {
            Cycle machineCycle = new Cycle(); //initialise cycle object

            //connect to database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //SQL query
                var sql = @"SELECT a.*
                            FROM [FinalYearProject].[dbo].[Turbofan_Engine] a
                            INNER JOIN (
		                        SELECT [ID], MAX([Cycle]) cycle
		                        FROM [FinalYearProject].[dbo].[Turbofan_Engine]
		                        WHERE [ID] = @ID
		                        GROUP BY [ID]
		                    ) b ON a.ID = b.ID AND a.Cycle = b.cycle";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@ID", ID);
                SqlDataReader dr = cmd.ExecuteReader();

                //get data
                while (dr.Read())
                {
                    machineCycle.ID = dr.GetInt32(dr.GetOrdinal("ID"));
                    machineCycle.cycle = dr.GetInt32(dr.GetOrdinal("Cycle"));
                    machineCycle.OpSet1 = (double)dr.GetDecimal(dr.GetOrdinal("OpSet1"));
                    machineCycle.OpSet2 = (double)dr.GetDecimal(dr.GetOrdinal("OpSet2"));
                    machineCycle.OpSet3 = (double)dr.GetDecimal(dr.GetOrdinal("OpSet3"));

                    for (int i = 1; i <= 21; i++)
                    {
                        machineCycle.GetType().GetProperty("s_" + i).SetValue(machineCycle, (double)dr.GetDecimal(dr.GetOrdinal("SensorMeasure"+i)), null);
                    }
                }
                conn.Close();
            }
            return machineCycle;
        }

        /// <summary>
        /// update data every 5 minutes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void updateData(object sender, EventArgs e)
        {
            //show loading screen
            TopPanel.Visible = false;
            BottomPanel.Visible = false;
            loadingPanel.Visible = true;

            await showMachine(); //update engine data

            //unload loading screen
            TopPanel.Visible = true;
            BottomPanel.Visible = true;
            loadingPanel.Visible = false;
        }

        /// <summary>
        /// when drop down menu index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void MachineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show loading screen
            TopPanel.Visible = false;
            BottomPanel.Visible = false;
            loadingPanel.Visible = true;

            await showMachine(); //change engine data

            //unload loading screen
            TopPanel.Visible = true;
            BottomPanel.Visible = true;
            loadingPanel.Visible = false;
        }
    }
}
