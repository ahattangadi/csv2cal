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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            labelCurLen = new Label();
            label1 = new Label();
            trackBar1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)topBanner).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // topBanner
            // 
            topBanner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topBanner.BackColor = SystemColors.Highlight;
            topBanner.Image = Properties.Resources.BannerImage;
            topBanner.Location = new Point(-4, 0);
            topBanner.Name = "topBanner";
            topBanner.Size = new Size(529, 177);
            topBanner.SizeMode = PictureBoxSizeMode.Zoom;
            topBanner.TabIndex = 0;
            topBanner.TabStop = false;
            // 
            // textBoxCsvPath
            // 
            textBoxCsvPath.Location = new Point(6, 26);
            textBoxCsvPath.Name = "textBoxCsvPath";
            textBoxCsvPath.Size = new Size(352, 27);
            textBoxCsvPath.TabIndex = 1;
            // 
            // browseCsv
            // 
            browseCsv.Image = Properties.Resources.OpenFile;
            browseCsv.Location = new Point(364, 26);
            browseCsv.Name = "browseCsv";
            browseCsv.Size = new Size(119, 29);
            browseCsv.TabIndex = 2;
            browseCsv.Text = "Browse";
            browseCsv.TextImageRelation = TextImageRelation.TextBeforeImage;
            browseCsv.UseVisualStyleBackColor = true;
            browseCsv.Click += browseCsv_Click;
            // 
            // labelCsvPath
            // 
            labelCsvPath.AutoSize = true;
            labelCsvPath.Location = new Point(6, 3);
            labelCsvPath.Name = "labelCsvPath";
            labelCsvPath.Size = new Size(85, 20);
            labelCsvPath.TabIndex = 3;
            labelCsvPath.Text = "Path to CSV";
            // 
            // labelIcalPath
            // 
            labelIcalPath.AutoSize = true;
            labelIcalPath.Location = new Point(6, 69);
            labelIcalPath.Name = "labelIcalPath";
            labelIcalPath.Size = new Size(117, 20);
            labelIcalPath.TabIndex = 6;
            labelIcalPath.Text = "Path to save iCal";
            // 
            // browseIcal
            // 
            browseIcal.Image = Properties.Resources.OpenFile;
            browseIcal.Location = new Point(361, 92);
            browseIcal.Name = "browseIcal";
            browseIcal.Size = new Size(122, 29);
            browseIcal.TabIndex = 5;
            browseIcal.Text = "Browse";
            browseIcal.TextImageRelation = TextImageRelation.TextBeforeImage;
            browseIcal.UseVisualStyleBackColor = true;
            browseIcal.Click += browseIcal_Click;
            // 
            // textBoxIcalPath
            // 
            textBoxIcalPath.Location = new Point(6, 92);
            textBoxIcalPath.Name = "textBoxIcalPath";
            textBoxIcalPath.Size = new Size(349, 27);
            textBoxIcalPath.TabIndex = 4;
            // 
            // buttonStartProcess
            // 
            buttonStartProcess.Location = new Point(6, 127);
            buttonStartProcess.Name = "buttonStartProcess";
            buttonStartProcess.Size = new Size(477, 29);
            buttonStartProcess.TabIndex = 7;
            buttonStartProcess.Text = "Start process";
            buttonStartProcess.UseVisualStyleBackColor = true;
            buttonStartProcess.Click += buttonStartProcess_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 194);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(502, 270);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelCsvPath);
            tabPage1.Controls.Add(textBoxCsvPath);
            tabPage1.Controls.Add(browseCsv);
            tabPage1.Controls.Add(buttonStartProcess);
            tabPage1.Controls.Add(textBoxIcalPath);
            tabPage1.Controls.Add(labelIcalPath);
            tabPage1.Controls.Add(browseIcal);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(494, 237);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Convert";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Transparent;
            tabPage2.Controls.Add(labelCurLen);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(trackBar1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(494, 237);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            // 
            // labelCurLen
            // 
            labelCurLen.AutoSize = true;
            labelCurLen.Location = new Point(6, 35);
            labelCurLen.Name = "labelCurLen";
            labelCurLen.Size = new Size(108, 20);
            labelCurLen.TabIndex = 3;
            labelCurLen.Text = "$currentLength";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(176, 20);
            label1.TabIndex = 2;
            label1.Text = "Length of Event (hours)";
            // 
            // trackBar1
            // 
            trackBar1.BackColor = SystemColors.ButtonFace;
            trackBar1.Location = new Point(6, 58);
            trackBar1.Maximum = 24;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(482, 56);
            trackBar1.TabIndex = 1;
            trackBar1.Value = 24;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(523, 476);
            Controls.Add(tabControl1);
            Controls.Add(topBanner);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "csv2cal";
            ((System.ComponentModel.ISupportInitialize)topBanner).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TrackBar trackBar1;
        private Label label1;
        private Label labelCurLen;
    }
}