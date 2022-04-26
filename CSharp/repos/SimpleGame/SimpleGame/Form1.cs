using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGame
{
    public partial class Form1 : Form
    {
        Dictionary<DateTime, List<DayEvent>> allEvents;
        List<DayEvent> singleDay; 
        public Form1()
        {
            InitializeComponent();
            allEvents = new Dictionary<DateTime, List<DayEvent>>();
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            DateTime selectedStartDate = monthCalendar1.SelectionStart;
            DateTime selectedEndDate = monthCalendar1.SelectionEnd;
            DayEvent de = new DayEvent( taskText.Text, selectedStartDate );
            allEvents.Add(selectedStartDate, de);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
