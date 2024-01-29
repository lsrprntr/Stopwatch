using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Stopwatch : Form
    {

        private DateTime startTime;

        public Stopwatch()
        {
            InitializeComponent();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            // Sets start time
            startTime = DateTime.Now;

            // Start formTimer
            formTimer.Start(); 

        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            formTimer.Stop();

        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            // Reset Label and stop timer
            formTimer.Stop();
            watchLabel.Text = "00:00.00";

        }

        private void formTimer_Tick(object sender, EventArgs e)
        {
            // Calculate time elapsed
            TimeSpan ts = DateTime.Now - startTime;
            watchLabel.Text = ts.ToString(@"mm\:ss\.ff");
        }
    }
}
