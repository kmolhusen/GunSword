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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Welcome wlm = new Welcome();
            
            wlm.Show();
            
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.Hide();
        }
    }
}
