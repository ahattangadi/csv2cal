using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace csv2cal.gui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            labelCurLen.Text = Properties.Settings.Default.LengthOfEvents.ToString();
            trackBar1.Value = Properties.Settings.Default.LengthOfEvents;
        }

        private void browseCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog CsvDialog = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                RestoreDirectory = true,
                Title = "Browse for CSV file",
                Filter = "CSV Files (*.csv)|*.csv"
            };

            if (CsvDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxCsvPath.Text = CsvDialog.FileName;
            }

        }

        private void browseIcal_Click(object sender, EventArgs e)
        {
            SaveFileDialog IcalDialog = new SaveFileDialog()
            {
                InitialDirectory = @"C:\",
                RestoreDirectory = true,
                Title = "Save iCal file",
                Filter = "iCal files (*.ics)|*.ics"
            };

            IcalDialog.ShowDialog();

            if (IcalDialog.FileName != "")
            {
                textBoxIcalPath.Text = IcalDialog.FileName;
            }
        }

        private void buttonStartProcess_Click(object sender, EventArgs e)
        {
            if (textBoxCsvPath.Text != "" && textBoxIcalPath.Text != "")
            {
                ConvertForm childForm = new ConvertForm(textBoxCsvPath.Text, textBoxIcalPath.Text);
                childForm.Show();
            }
            else
            {
                MessageBox.Show("1/more paths have not been provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LengthOfEvents = trackBar1.Value;
            Properties.Settings.Default.Save();
            labelCurLen.Text = Properties.Settings.Default.LengthOfEvents.ToString();
        }
    }
}