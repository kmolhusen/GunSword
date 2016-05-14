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

        int min, sec, ms = 0;

        public void btnStart_Click(object sender, EventArgs e)
        {
            
                timer1.Start();
                SoundPlayer sp = new SoundPlayer(@"partyhorn.wav");
                sp.Play();
            
            

            
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            lblDisplay.Text = min + ":" + sec + ":" + ms;
            ms++;
            if (ms > 9)
            {
                sec++;
                ms = 0;
                    if (sec > 59)
                    {
                        min++;
                        sec = 0;
                    }
            }
            if (min == 25)
            {
                timer1.Stop();
                SoundPlayer sp = new SoundPlayer(@"partyhorn.wav");
                sp.Play();
                for (int i = 0; i < 100; i++)
                {
                    lblDisplay.Hide();
                    lblDisplay.Show();
                }
            }


        }
    }
}
