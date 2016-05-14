using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyPomodoro
{
    public partial class frmPomodoro : Form
    {
        public frmPomodoro()
        {
            InitializeComponent();

        }

        int min, sec, ms = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            
                timer1.Start();
            

            
        }

        private void timer1_Tick(object sender, EventArgs e)
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

                for (int i = 0; i < 20; i++)
                {
                    lblDisplay.Hide();
                    lblDisplay.Show();
                }
            }


        }
    }
}
