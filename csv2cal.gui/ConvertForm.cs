using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using Ical.Net.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csv2cal.gui
{
    public partial class ConvertForm : Form
    {
        public string csvPath;
        public string icalPath;

        public ConvertForm(string csvPath, string iCalPath)
        {
            InitializeComponent();
            this.csvPath = csvPath;
            this.icalPath = iCalPath;
        }

        private void ConvertForm_Load(object sender, EventArgs e)
        {
            labelStatus.Text = "Parsing file: " + csvPath;
            try
            {
                BindData(csvPath);
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                labelStatus.Text = ex.Message;
            }

            labelStatus.Text = "Please select columns with required data";


        }

        private void BindData(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            }
        }

        private void buttonSetDate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                textBoxDateSelect.Text = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText;
            }
            else
            {
                MessageBox.Show("No column is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSetTitle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                textBoxTitleSelect.Text = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText;
            }
            else
            {
                MessageBox.Show("No column is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonConvertToIcal_Click(object sender, EventArgs e)
        {
            int _dateColumnIndex = dataGridView1.Columns[textBoxDateSelect.Text].Index;
            int _titleColumnIndex = dataGridView1.Columns[textBoxTitleSelect.Text].Index;
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            var cal = new Ical.Net.Calendar
            {
                Method = "PUBLISH",
            };
            labelStatus.Text = "Converting to iCal ...";


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string? _date = row.Cells[_dateColumnIndex].Value.ToString();
                string? _title = row.Cells[_titleColumnIndex].Value.ToString();

                if (_title != "" && _date != "")
                {
                    keyValuePairs.Add(_date, _title);
                }
            }

            progressBar1.Maximum = 2 * keyValuePairs.Count;
            progressBar1.Value = keyValuePairs.Count;

            foreach (KeyValuePair<string, string> pair in keyValuePairs)
            {
                DateTime _dateTime = DateTime.Parse(pair.Key);
                string _title = pair.Value;

                var calendarevent = new CalendarEvent
                {
                    Start = new CalDateTime(_dateTime),
                    End = new CalDateTime(_dateTime.AddDays(1)),
                    Summary = _title,
                };

                cal.Events.Add(calendarevent);
                progressBar1.Increment(1);
            }

            var serializer = new CalendarSerializer();
            var serializedCalendar = serializer.SerializeToString(cal);

            try
            {
                using (FileStream fs = File.Create(icalPath))
                {
                    byte[] info = new UTF8Encoding().GetBytes(serializedCalendar);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                labelStatus.Text = ex.Message;
            }

            labelStatus.Text = ".ics file generated";

            DialogResult dlg = MessageBox.Show("iCal file successfully created", "File created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dlg.Equals(DialogResult.OK))
            {
                this.Close();
            }
        }
    }
}
