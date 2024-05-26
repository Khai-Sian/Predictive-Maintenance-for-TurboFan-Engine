
namespace Dashboard_UI
{
    partial class ModelForm
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
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelList = new System.Windows.Forms.ComboBox();
            this.TrainRMSE = new System.Windows.Forms.Label();
            this.TrainRMSEMeasure = new System.Windows.Forms.Label();
            this.TestRMSE = new System.Windows.Forms.Label();
            this.TestRMSEMeasure = new System.Windows.Forms.Label();
            this.TrainR2 = new System.Windows.Forms.Label();
            this.TestR2 = new System.Windows.Forms.Label();
            this.TrainR2Measure = new System.Windows.Forms.Label();
            this.TestR2Measure = new System.Windows.Forms.Label();
            this.ROC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ROC)).BeginInit();
            this.SuspendLayout();
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.ModelLabel.Location = new System.Drawing.Point(13, 13);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(180, 25);
            this.ModelLabel.TabIndex = 0;
            this.ModelLabel.Text = "Model Available";
            // 
            // ModelList
            // 
            this.ModelList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelList.FormattingEnabled = true;
            this.ModelList.Location = new System.Drawing.Point(12, 41);
            this.ModelList.Name = "ModelList";
            this.ModelList.Size = new System.Drawing.Size(297, 29);
            this.ModelList.TabIndex = 1;
            this.ModelList.SelectedIndexChanged += new System.EventHandler(this.ModelList_SelectedIndexChanged);
            // 
            // TrainRMSE
            // 
            this.TrainRMSE.AutoSize = true;
            this.TrainRMSE.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainRMSE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TrainRMSE.Location = new System.Drawing.Point(20, 120);
            this.TrainRMSE.Name = "TrainRMSE";
            this.TrainRMSE.Size = new System.Drawing.Size(153, 23);
            this.TrainRMSE.TabIndex = 2;
            this.TrainRMSE.Text = "RMSE (Train Set)";
            // 
            // TrainRMSEMeasure
            // 
            this.TrainRMSEMeasure.AutoSize = true;
            this.TrainRMSEMeasure.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainRMSEMeasure.ForeColor = System.Drawing.Color.White;
            this.TrainRMSEMeasure.Location = new System.Drawing.Point(18, 143);
            this.TrainRMSEMeasure.Name = "TrainRMSEMeasure";
            this.TrainRMSEMeasure.Size = new System.Drawing.Size(96, 33);
            this.TrainRMSEMeasure.TabIndex = 3;
            this.TrainRMSEMeasure.Text = "label1";
            // 
            // TestRMSE
            // 
            this.TestRMSE.AutoSize = true;
            this.TestRMSE.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestRMSE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TestRMSE.Location = new System.Drawing.Point(286, 119);
            this.TestRMSE.Name = "TestRMSE";
            this.TestRMSE.Size = new System.Drawing.Size(144, 23);
            this.TestRMSE.TabIndex = 4;
            this.TestRMSE.Text = "RMSE (Test Set)";
            // 
            // TestRMSEMeasure
            // 
            this.TestRMSEMeasure.AutoSize = true;
            this.TestRMSEMeasure.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestRMSEMeasure.ForeColor = System.Drawing.Color.White;
            this.TestRMSEMeasure.Location = new System.Drawing.Point(284, 146);
            this.TestRMSEMeasure.Name = "TestRMSEMeasure";
            this.TestRMSEMeasure.Size = new System.Drawing.Size(96, 33);
            this.TestRMSEMeasure.TabIndex = 5;
            this.TestRMSEMeasure.Text = "label1";
            // 
            // TrainR2
            // 
            this.TrainR2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainR2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TrainR2.Location = new System.Drawing.Point(20, 228);
            this.TrainR2.Name = "TrainR2";
            this.TrainR2.Size = new System.Drawing.Size(137, 23);
            this.TrainR2.TabIndex = 6;
            this.TrainR2.Text = "R2 (Train Set)";
            // 
            // TestR2
            // 
            this.TestR2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestR2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TestR2.Location = new System.Drawing.Point(286, 228);
            this.TestR2.Name = "TestR2";
            this.TestR2.Size = new System.Drawing.Size(121, 23);
            this.TestR2.TabIndex = 7;
            this.TestR2.Text = "R2 (Test Set)";
            // 
            // TrainR2Measure
            // 
            this.TrainR2Measure.AutoSize = true;
            this.TrainR2Measure.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainR2Measure.ForeColor = System.Drawing.Color.White;
            this.TrainR2Measure.Location = new System.Drawing.Point(18, 251);
            this.TrainR2Measure.Name = "TrainR2Measure";
            this.TrainR2Measure.Size = new System.Drawing.Size(96, 33);
            this.TrainR2Measure.TabIndex = 8;
            this.TrainR2Measure.Text = "label1";
            // 
            // TestR2Measure
            // 
            this.TestR2Measure.AutoSize = true;
            this.TestR2Measure.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestR2Measure.ForeColor = System.Drawing.Color.White;
            this.TestR2Measure.Location = new System.Drawing.Point(284, 251);
            this.TestR2Measure.Name = "TestR2Measure";
            this.TestR2Measure.Size = new System.Drawing.Size(96, 33);
            this.TestR2Measure.TabIndex = 9;
            this.TestR2Measure.Text = "label1";
            // 
            // ROC
            // 
            this.ROC.Location = new System.Drawing.Point(24, 326);
            this.ROC.Name = "ROC";
            this.ROC.Size = new System.Drawing.Size(406, 250);
            this.ROC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ROC.TabIndex = 10;
            this.ROC.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.ROC);
            this.Controls.Add(this.TestR2Measure);
            this.Controls.Add(this.TrainR2Measure);
            this.Controls.Add(this.TestR2);
            this.Controls.Add(this.TrainR2);
            this.Controls.Add(this.TestRMSEMeasure);
            this.Controls.Add(this.TestRMSE);
            this.Controls.Add(this.TrainRMSEMeasure);
            this.Controls.Add(this.TrainRMSE);
            this.Controls.Add(this.ModelList);
            this.Controls.Add(this.ModelLabel);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.ROC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.ComboBox ModelList;
        private System.Windows.Forms.Label TrainRMSE;
        private System.Windows.Forms.Label TrainRMSEMeasure;
        private System.Windows.Forms.Label TestRMSE;
        private System.Windows.Forms.Label TestRMSEMeasure;
        private System.Windows.Forms.Label TrainR2;
        private System.Windows.Forms.Label TestR2;
        private System.Windows.Forms.Label TrainR2Measure;
        private System.Windows.Forms.Label TestR2Measure;
        private System.Windows.Forms.PictureBox ROC;
    }
}