using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaGame
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();

            
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            label2.ForeColor = Color.FromArgb(A, R, G, B);
        }
    }
}
