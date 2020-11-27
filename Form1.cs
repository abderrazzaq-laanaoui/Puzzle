using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Puzzle : Form
    {
        private int TotalTime;
        public Puzzle()
        {
            InitializeComponent();
        }

        private void Puzzle_Load(object sender, EventArgs e)
        {
            this.end.Enabled = false;
            this.modes.SelectedIndex = 1;

        }

        private void start_Click(object sender, EventArgs e)
        {
            start.Enabled = false;
            modes.Enabled = false;
            end.Enabled = true;

            //set the time based on difficulty  and start the timer
            switch (modes.SelectedIndex)
            {
                case 0:
                    this.TotalTime = 600;
                    break;
                case 1:
                    this.TotalTime = 300;
                    break;
                case 2:
                    this.TotalTime = 180;
                    break;
                default:
                    break;
            }
            this.timer.Enabled = true;


        }

        private void end_Click(object sender, EventArgs e)
        {
            end.Enabled = false;
            start.Enabled = true;
            modes.Enabled = true;
            timer.Stop();   
            clock.Text = "00:00";
            
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(this.TotalTime>0)
            {
                TotalTime--;
                int minutes = TotalTime / 60;
                int seconds = TotalTime - (minutes * 60);
                clock.Text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }
            else
            {
                timer.Stop();
                MessageBox.Show("time is up!");
            }

        }
    }
}
