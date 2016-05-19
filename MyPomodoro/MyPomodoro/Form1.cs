using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MyPomodoro
{
    public partial class frmPomodoro : Form
    {
        public frmPomodoro()
        {
            InitializeComponent();

        }

        int min = 24;
        int sec = 59;
        int ms = 9;

        public void btnStart_Click(object sender, EventArgs e)
        {
            
                timer1.Start();
                SoundPlayer sp = new SoundPlayer(@"partyhorn.wav");
                sp.Play();
            
            

            
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            lblDisplay.Text = min + ":" + sec + ":" + ms;
            ms--;
            if (ms < 0)
            {
                
                sec--;
                ms = 9;
                    if (sec < 0)
                    {
                        min--;
                        sec = 59;
                    }
            }

            if (min < 0)
            {

                timer1.Stop();
                min = 0;
                sec = 0;
                ms = 0;
                SoundPlayer sp = new SoundPlayer(@"partyhorn.wav");
                sp.Play();
                for (int i = 0; i < 100; i++)
                {
                    lblDisplay.Hide();
                    lblDisplay.Show();
                }

            }

        }

        public void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            min = 24;
            sec = 59;
            ms = 9;
            lblDisplay.Text = min + ":" + sec + ":" + ms;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            min -= 2;
        }
    }
}
