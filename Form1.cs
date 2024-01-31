using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Stopwatch : Form
    {

        private DateTime startTime;
        private DateTime stopTime;
        private TimeSpan elapsedTime;
        private bool running = false;

        public Stopwatch()
        {
            InitializeComponent();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                // Sets start time
                startTime = DateTime.Now;
                elapsedTime = TimeSpan.Zero;
                // Start formTimer
                running = true;
            }
            else
            {
                // Accumulate elapsed time to account for from new startTime
                elapsedTime += (DateTime.Now - startTime);
                startTime = DateTime.Now;
                
            }

            formTimer.Start();
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            formTimer.Stop();
            // Record stop time
            startTime = DateTime.Now;

        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            // Reset Label and stop timer
            formTimer.Stop();
            watchLabel.Text = "00:00.00";
            running = false;

        }

        private void formTimer_Tick(object sender, EventArgs e)
        {
            // Calculate time elapsed
            TimeSpan ts = (DateTime.Now - startTime) + elapsedTime;
            watchLabel.Text = ts.ToString(@"mm\:ss\.ff");
        }
    }
}
