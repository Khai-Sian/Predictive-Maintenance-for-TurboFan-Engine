
namespace Dashboard_UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SideMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SpeechRecognitionButton = new Dashboard_UI.ToggleButton();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.ModelButton = new System.Windows.Forms.Button();
            this.EngineButton = new System.Windows.Forms.Button();
            this.LockButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.SideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.SideMenu.Controls.Add(this.ModelButton);
            this.SideMenu.Controls.Add(this.panel1);
            this.SideMenu.Controls.Add(this.EngineButton);
            this.SideMenu.Controls.Add(this.LockButton);
            this.SideMenu.Controls.Add(this.Logo);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(120, 800);
            this.SideMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SpeechRecognitionButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 680);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30, 45, 30, 45);
            this.panel1.Size = new System.Drawing.Size(120, 120);
            this.panel1.TabIndex = 4;
            // 
            // SpeechRecognitionButton
            // 
            this.SpeechRecognitionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpeechRecognitionButton.Location = new System.Drawing.Point(30, 45);
            this.SpeechRecognitionButton.Margin = new System.Windows.Forms.Padding(0);
            this.SpeechRecognitionButton.MinimumSize = new System.Drawing.Size(45, 22);
            this.SpeechRecognitionButton.Name = "SpeechRecognitionButton";
            this.SpeechRecognitionButton.OffBackColor = System.Drawing.Color.Gray;
            this.SpeechRecognitionButton.OffToggleColor = System.Drawing.Color.White;
            this.SpeechRecognitionButton.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(219)))), ((int)(((byte)(91)))));
            this.SpeechRecognitionButton.OnToggleColor = System.Drawing.Color.White;
            this.SpeechRecognitionButton.Size = new System.Drawing.Size(60, 30);
            this.SpeechRecognitionButton.TabIndex = 4;
            this.SpeechRecognitionButton.UseVisualStyleBackColor = true;
            this.SpeechRecognitionButton.CheckStateChanged += new System.EventHandler(this.SpeechRecognitionButton_CheckStateChanged);
            // 
            // childFormPanel
            // 
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(120, 0);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(1300, 800);
            this.childFormPanel.TabIndex = 2;
            // 
            // ModelButton
            // 
            this.ModelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.ModelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ModelButton.FlatAppearance.BorderSize = 0;
            this.ModelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModelButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelButton.ForeColor = System.Drawing.Color.White;
            this.ModelButton.Image = global::Dashboard_UI.Properties.Resources.Model;
            this.ModelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModelButton.Location = new System.Drawing.Point(0, 230);
            this.ModelButton.Name = "ModelButton";
            this.ModelButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ModelButton.Size = new System.Drawing.Size(120, 60);
            this.ModelButton.TabIndex = 5;
            this.ModelButton.Text = "Model";
            this.ModelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ModelButton.UseVisualStyleBackColor = false;
            this.ModelButton.Click += new System.EventHandler(this.ModelButton_Click);
            // 
            // EngineButton
            // 
            this.EngineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.EngineButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EngineButton.FlatAppearance.BorderSize = 0;
            this.EngineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EngineButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineButton.ForeColor = System.Drawing.Color.White;
            this.EngineButton.Image = global::Dashboard_UI.Properties.Resources.Turbofan;
            this.EngineButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EngineButton.Location = new System.Drawing.Point(0, 170);
            this.EngineButton.Name = "EngineButton";
            this.EngineButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.EngineButton.Size = new System.Drawing.Size(120, 60);
            this.EngineButton.TabIndex = 3;
            this.EngineButton.Text = "Engine";
            this.EngineButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EngineButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EngineButton.UseVisualStyleBackColor = false;
            this.EngineButton.Click += new System.EventHandler(this.EngineButton_Click);
            // 
            // LockButton
            // 
            this.LockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.LockButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LockButton.FlatAppearance.BorderSize = 0;
            this.LockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LockButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockButton.ForeColor = System.Drawing.Color.White;
            this.LockButton.Image = global::Dashboard_UI.Properties.Resources.LockScreen;
            this.LockButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LockButton.Location = new System.Drawing.Point(0, 110);
            this.LockButton.Name = "LockButton";
            this.LockButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.LockButton.Size = new System.Drawing.Size(120, 60);
            this.LockButton.TabIndex = 2;
            this.LockButton.Text = "Lock";
            this.LockButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LockButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LockButton.UseVisualStyleBackColor = false;
            this.LockButton.Click += new System.EventHandler(this.LockButton_Click);
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Image = global::Dashboard_UI.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Padding = new System.Windows.Forms.Padding(20);
            this.Logo.Size = new System.Drawing.Size(120, 110);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1420, 800);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.SideMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Button LockButton;
        private System.Windows.Forms.Button EngineButton;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.PictureBox Logo;
        private ToggleButton SpeechRecognitionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ModelButton;
    }
}

