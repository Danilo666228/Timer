using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        private int m, s, ms;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btnStop.Text = "Старт";
            }
            else
            {
                timer1.Start();
                btnStop.Text = "Стоп";
            }
        }

        private void btnSbros_Click(object sender, EventArgs e)
        {
            m = 0; s = 0; ms = 0;
            label3.Text = "0:0.0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
            ms++;
            s = ms / 10;
            m = s / 60;
            label3.Text = m + ":" + s % 60 + "." + ms % 10;
        }
    }
}
