using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_O_Name
{
    public partial class FormFileOName : Form
    {
        private string _dateString="";
        private string _topic;
        private string _author;
        private string _status;

        public FormFileOName()
        {
            InitializeComponent();
            monthCalendar.DateChanged += OnCalendarDateChanged;
        }

        private void OnCalendarDateChanged(object sender, System.EventArgs e)
        {
            SelectionRange dateSelection = monthCalendar.SelectionRange;
            TimeSpan DateRange = dateSelection.End - dateSelection.Start;
            _dateString = monthCalendar.SelectionStart.Date.ToString("yyyyMMdd");
            SetFilename();
            
        }

        private void lstFileStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormFileOName_Load(object sender, EventArgs e)
        {

        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtFilename.Text = _dateString;
        }

        private void SetFilename()
        {
            string fileName = $"{_dateString} {_topic} {_author} {_status}";
            txtFilename.Text = fileName;
        }
    }
}
