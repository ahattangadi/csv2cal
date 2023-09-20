namespace csv2cal.gui
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            topBanner = new PictureBox();
            textBoxCsvPath = new TextBox();
            browseCsv = new Button();
            labelCsvPath = new Label();
            labelIcalPath = new Label();
            browseIcal = new Button();
            textBoxIcalPath = new TextBox();
            buttonStartProcess = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)topBanner).BeginInit();
            SuspendLayout();
            // 
            // topBanner
            // 
            topBanner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topBanner.BackColor = SystemColors.Highlight;
            topBanner.Image = Properties.Resources.BannerImage;
            topBanner.Location = new Point(-4, 0);
            topBanner.Name = "topBanner";
            topBanner.Size = new Size(503, 168);
            topBanner.SizeMode = PictureBoxSizeMode.Zoom;
            topBanner.TabIndex = 0;
            topBanner.TabStop = false;
            // 
            // textBoxCsvPath
            // 
            textBoxCsvPath.Location = new Point(12, 204);
            textBoxCsvPath.Name = "textBoxCsvPath";
            textBoxCsvPath.Size = new Size(352, 27);
            textBoxCsvPath.TabIndex = 1;
            // 
            // browseCsv
            // 
            browseCsv.Location = new Point(370, 204);
            browseCsv.Name = "browseCsv";
            browseCsv.Size = new Size(119, 29);
            browseCsv.TabIndex = 2;
            browseCsv.Text = "Browse ...";
            browseCsv.UseVisualStyleBackColor = true;
            browseCsv.Click += browseCsv_Click;
            // 
            // labelCsvPath
            // 
            labelCsvPath.AutoSize = true;
            labelCsvPath.Location = new Point(12, 181);
            labelCsvPath.Name = "labelCsvPath";
            labelCsvPath.Size = new Size(85, 20);
            labelCsvPath.TabIndex = 3;
            labelCsvPath.Text = "Path to CSV";
            // 
            // labelIcalPath
            // 
            labelIcalPath.AutoSize = true;
            labelIcalPath.Location = new Point(12, 247);
            labelIcalPath.Name = "labelIcalPath";
            labelIcalPath.Size = new Size(117, 20);
            labelIcalPath.TabIndex = 6;
            labelIcalPath.Text = "Path to save iCal";
            // 
            // browseIcal
            // 
            browseIcal.Location = new Point(367, 270);
            browseIcal.Name = "browseIcal";
            browseIcal.Size = new Size(122, 29);
            browseIcal.TabIndex = 5;
            browseIcal.Text = "Browse ...";
            browseIcal.UseVisualStyleBackColor = true;
            browseIcal.Click += browseIcal_Click;
            // 
            // textBoxIcalPath
            // 
            textBoxIcalPath.Location = new Point(12, 270);
            textBoxIcalPath.Name = "textBoxIcalPath";
            textBoxIcalPath.Size = new Size(349, 27);
            textBoxIcalPath.TabIndex = 4;
            // 
            // buttonStartProcess
            // 
            buttonStartProcess.Location = new Point(12, 305);
            buttonStartProcess.Name = "buttonStartProcess";
            buttonStartProcess.Size = new Size(477, 29);
            buttonStartProcess.TabIndex = 7;
            buttonStartProcess.Text = "Start process";
            buttonStartProcess.UseVisualStyleBackColor = true;
            buttonStartProcess.Click += buttonStartProcess_Click;
            // 
            // label2
            // 
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(12, 371);
            label2.Name = "label2";
            label2.Size = new Size(477, 48);
            label2.TabIndex = 10;
            label2.Text = "A simple program designed to convert CSV files to iCal files.\r\n(C) 2023, Aarav Hattangadi";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(497, 428);
            Controls.Add(label2);
            Controls.Add(buttonStartProcess);
            Controls.Add(labelIcalPath);
            Controls.Add(browseIcal);
            Controls.Add(textBoxIcalPath);
            Controls.Add(labelCsvPath);
            Controls.Add(browseCsv);
            Controls.Add(textBoxCsvPath);
            Controls.Add(topBanner);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "csv2cal";
            ((System.ComponentModel.ISupportInitialize)topBanner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox topBanner;
        private TextBox textBoxCsvPath;
        private Button browseCsv;
        private Label labelCsvPath;
        private Label labelIcalPath;
        private Button browseIcal;
        private TextBox textBoxIcalPath;
        private Button buttonStartProcess;
        private Label label2;
    }
}