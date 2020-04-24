using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using System.Numerics;
using System.Threading;

namespace Time_Until_my_Birthday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Utils.Controls.Corners.Set_BorderLess(this, 10);
        }

        void HideAll()
        {
            foreach (Control c in this.Controls)
            {
                Thread.Sleep(10);
                bunifuTransition1.Hide(c);
                bunifuTransition1.HideSync(seconds);
            }
        }

        DateTime endtime = new DateTime(2021, 1, 30, 0, 0, 0);

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = endtime.Subtract(DateTime.Now);

            miliseconds.Text = ts.Milliseconds.ToString();
            seconds.Text = ts.Seconds.ToString();
            minutes.Text = ts.Minutes.ToString();
            hours.Text = ts.Hours.ToString();
            days.Text = ts.Days.ToString();

            if (BigInteger.Parse(seconds.Text) < 0)
            {
                timer1.Stop();
                miliseconds.Text = "0";
                seconds.Text = "0";
                minutes.Text = "0";
                hours.Text = "0";
                days.Text = "0";
                Thread th = new Thread(new ThreadStart(HideAll));
                th.Start();
            }
        }
    }
}
