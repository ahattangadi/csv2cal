namespace csv2cal.gui
{
    partial class ConvertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertForm));
            labelStatus = new Label();
            dataGridView1 = new DataGridView();
            textBoxDateSelect = new TextBox();
            buttonSetDate = new Button();
            labelDate = new Label();
            labelTitle = new Label();
            buttonSetTitle = new Button();
            textBoxTitleSelect = new TextBox();
            buttonConvertToIcal = new Button();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(12, 9);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(50, 20);
            labelStatus.TabIndex = 0;
            labelStatus.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(472, 275);
            dataGridView1.TabIndex = 1;
            // 
            // textBoxDateSelect
            // 
            textBoxDateSelect.Location = new Point(62, 333);
            textBoxDateSelect.Name = "textBoxDateSelect";
            textBoxDateSelect.ReadOnly = true;
            textBoxDateSelect.Size = new Size(238, 27);
            textBoxDateSelect.TabIndex = 2;
            // 
            // buttonSetDate
            // 
            buttonSetDate.Location = new Point(306, 332);
            buttonSetDate.Name = "buttonSetDate";
            buttonSetDate.Size = new Size(178, 29);
            buttonSetDate.TabIndex = 3;
            buttonSetDate.Text = "Set to current selection";
            buttonSetDate.UseVisualStyleBackColor = true;
            buttonSetDate.Click += buttonSetDate_Click;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 336);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(44, 20);
            labelDate.TabIndex = 4;
            labelDate.Text = "Date:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 383);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(41, 20);
            labelTitle.TabIndex = 7;
            labelTitle.Text = "Title:";
            // 
            // buttonSetTitle
            // 
            buttonSetTitle.Location = new Point(306, 378);
            buttonSetTitle.Name = "buttonSetTitle";
            buttonSetTitle.Size = new Size(178, 29);
            buttonSetTitle.TabIndex = 6;
            buttonSetTitle.Text = "Set to current selection";
            buttonSetTitle.UseVisualStyleBackColor = true;
            buttonSetTitle.Click += buttonSetTitle_Click;
            // 
            // textBoxTitleSelect
            // 
            textBoxTitleSelect.Location = new Point(62, 380);
            textBoxTitleSelect.Name = "textBoxTitleSelect";
            textBoxTitleSelect.ReadOnly = true;
            textBoxTitleSelect.Size = new Size(238, 27);
            textBoxTitleSelect.TabIndex = 5;
            // 
            // buttonConvertToIcal
            // 
            buttonConvertToIcal.Location = new Point(12, 425);
            buttonConvertToIcal.Name = "buttonConvertToIcal";
            buttonConvertToIcal.Size = new Size(472, 29);
            buttonConvertToIcal.TabIndex = 8;
            buttonConvertToIcal.Text = "Convert to iCal";
            buttonConvertToIcal.UseVisualStyleBackColor = true;
            buttonConvertToIcal.Click += buttonConvertToIcal_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 460);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(472, 29);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 9;
            // 
            // ConvertForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(501, 511);
            Controls.Add(labelStatus);
            Controls.Add(progressBar1);
            Controls.Add(dataGridView1);
            Controls.Add(labelDate);
            Controls.Add(buttonConvertToIcal);
            Controls.Add(buttonSetDate);
            Controls.Add(textBoxTitleSelect);
            Controls.Add(buttonSetTitle);
            Controls.Add(labelTitle);
            Controls.Add(textBoxDateSelect);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConvertForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Convert to iCal";
            Load += ConvertForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelStatus;
        private DataGridView dataGridView1;
        private TextBox textBoxDateSelect;
        private Button buttonSetDate;
        private Label labelDate;
        private Label labelTitle;
        private Button buttonSetTitle;
        private TextBox textBoxTitleSelect;
        private Button buttonConvertToIcal;
        private ProgressBar progressBar1;
    }
}