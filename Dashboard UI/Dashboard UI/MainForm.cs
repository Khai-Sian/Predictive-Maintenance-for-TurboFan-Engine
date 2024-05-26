using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Configuration;
using Humanizer;

namespace Dashboard_UI
{
    public partial class MainForm : Form
    {
        private Form engineForm = null;
        private Form modelForm = null;
        private Panel activePanel = null;
        private PictureBox lockImage = null;

        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine(); //initialise recogniser
        private int MachineNum = int.Parse(ConfigurationManager.AppSettings["MachineNum"]); //get number of engines from configuration file

        public MainForm()
        {
            InitializeComponent();

            #region remove form title bar
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            #endregion

            #region Model childForm
            //create model form to add in childFormPanel
            if (modelForm != null)
            {
                modelForm.Close();
            }
            //set form properties
            modelForm = new ModelForm();
            modelForm.Size = new Size(childFormPanel.Width, childFormPanel.Height);
            modelForm.TopLevel = false;
            modelForm.FormBorderStyle = FormBorderStyle.None;
            modelForm.Dock = DockStyle.Fill;

            //add to panel
            childFormPanel.Controls.Add(modelForm);
            childFormPanel.Tag = modelForm;
            modelForm.BringToFront();
            modelForm.Hide();
            #endregion

            #region Engine childForm
            //create engine form to add in childFormPanel
            if (engineForm != null)
            {
                engineForm.Close();
            }
            //set form properties
            engineForm = new EngineForm();
            engineForm.Size = new Size(childFormPanel.Width, childFormPanel.Height);
            engineForm.TopLevel = false;
            engineForm.FormBorderStyle = FormBorderStyle.None;
            engineForm.Dock = DockStyle.Fill;

            //add to panel
            childFormPanel.Controls.Add(engineForm);
            childFormPanel.Tag = engineForm;
            engineForm.BringToFront();
            engineForm.Show();
            #endregion

            #region Lock Screen Panel
            //create lock screen panel to add in childFormPanel
            if (activePanel != null)
            {
                activePanel.Dispose();
            }
            //set panel properties
            activePanel = new Panel();
            activePanel.Size = new Size(childFormPanel.Width, childFormPanel.Height);
            activePanel.Dock = DockStyle.Fill;
            activePanel.Padding = new Padding(300, 300, 300, 300);
            activePanel.BackColor = Color.FromArgb(30,31,44);

            //add image to panel
            lockImage = new PictureBox();
            lockImage.Dock = DockStyle.Fill;
            lockImage.Image = Properties.Resources.Lock;
            lockImage.SizeMode = PictureBoxSizeMode.Zoom;
            activePanel.Controls.Add(lockImage);

            //add to panel
            childFormPanel.Controls.Add(activePanel);
            childFormPanel.Tag = activePanel;
            activePanel.BringToFront();
            activePanel.Hide();
            #endregion

            //Side Menu Control
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 60);
            SideMenu.Controls.Add(leftBorderBtn);
            ActiveButton(EngineButton, Color.FromArgb(253, 138, 114));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            recEngine.SetInputToDefaultAudioDevice();

            Choices commands = new Choices();

            //set command for recognition engine
            for (int i  = 1; i <= MachineNum; i++)
            {
                commands.Add("Show Engine " + i.ToWords());
                commands.Add("Show Number " + i.ToWords());
            }
            commands.Add("Lock Screen");
            commands.Add("Show Engine");
            commands.Add("Show Model");

            //build grammar
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);

            recEngine.LoadGrammarAsync(new Grammar(gBuilder)); //load grammar to recogniser
            recEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecognized); //event when command detected
        }

        /// <summary>
        /// when command detected by recogniser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Default_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence >= 0.75) //if confidence more than 75%
            {
                string speech = e.Result.Text; //convert to string
                string[] tokens = speech.Split(' '); //number of words detected

                if (speech == "Lock Screen")
                {
                    LockButton_Click(LockButton, new EventArgs());
                }
                else if (speech == "Show Engine")
                {
                    EngineButton_Click(EngineButton, new EventArgs());
                }
                else if (speech == "Show Model")
                {
                    ModelButton_Click(ModelButton, new EventArgs());
                }
                else if (tokens.Length >= 3) //if mroe than 3 words deteced
                {
                    if (tokens[0] == "Show" && (tokens[1] == "Engine" || tokens[1] == "Number"))
                    {
                        string result = String.Join(" ", speech.Split(' ').Skip(2)); //catch words after first 2 words

                        try
                        {
                            int machineNumb = Convert.ToInt32(WordsToNumbers.ConvertToNumbers(result)); //convert to engine ID
                            EngineForm.machineList.SelectedIndex = machineNumb - 1; //change engine ID in engine form

                            EngineButton_Click(EngineButton, new EventArgs());
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
        }

        #region Side Menu Control
        /// <summary>
        /// when lock button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LockButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(255, 84, 112));
            engineForm.Hide();
            modelForm.Hide();
            activePanel.Show();
        }

        /// <summary>
        /// when engine button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EngineButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(253, 138, 114)); //show active button
            activePanel.Hide();
            modelForm.Hide();
            engineForm.Show();
        }

        /// <summary>
        /// when model button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModelButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(95, 77, 221)); //show active button
            activePanel.Hide();
            engineForm.Hide();
            modelForm.Show();
        }

        private Button activeButton;
        private Panel leftBorderBtn;
        private CheckBox SpeechRecognition;

        /// <summary>
        /// change button design when active
        /// </summary>
        /// <param name="senderBtn"></param>
        /// <param name="color"></param>
        private void ActiveButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                disableButton(); //disable previous active button
                //set button properties
                activeButton = (Button)senderBtn;
                activeButton.BackColor = Color.FromArgb(30, 31, 44);
                activeButton.ForeColor = color;
                activeButton.TextAlign = ContentAlignment.MiddleCenter;
                activeButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                activeButton.ImageAlign = ContentAlignment.MiddleRight;

                //Left Border 
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, activeButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        /// <summary>
        /// disable previoud active button
        /// </summary>
        private void disableButton()
        {
            if (activeButton != null)
            {
                //set button properties
                activeButton.BackColor = Color.FromArgb(36, 39, 54);
                activeButton.ForeColor = Color.FromArgb(255, 255, 255);
                activeButton.TextAlign = ContentAlignment.MiddleLeft;
                activeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                activeButton.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        /// <summary>
        /// logo icon clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logo_Click(object sender, EventArgs e)
        {
            disableButton();
            activePanel.Hide();
            engineForm.Show();
            ActiveButton(EngineButton, Color.FromArgb(253, 138, 114));
        }

        /// <summary>
        /// when button change state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpeechRecognitionButton_CheckStateChanged(object sender, EventArgs e)
        {
            SpeechRecognition = (CheckBox)sender;

            if (SpeechRecognition.CheckState == CheckState.Checked)
            {
                SpeechRecognition = (CheckBox)sender;
                recEngine.RecognizeAsync(RecognizeMode.Multiple); //activate recogniser
            }
            else
            {
                recEngine.RecognizeAsyncCancel(); //disable recogniser
            }
            
        }
        #endregion

        #region Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        
    }
}
