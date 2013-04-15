using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BB.Common.WinForms.Example
{
    public partial class ProgressBarDemo : MetroUserControl, IDemo
    {
        public ProgressBarDemo()
        {
            InitializeComponent();
        }

        public event EventHandler<ChangeDemoEventArgs> ChangeDemo;

        public string DemoName
        {
            get { return "MetroProgressBarDemo"; }
        }

        public Control GetControl()
        {
            return this;
        }

        private void ShowButtons_Click(object sender, EventArgs e)
        {
            string nextDemoName = ShowButtons.Tag as string;

            ChangeDemo.Fire(this, new ChangeDemoEventArgs(nextDemoName));
        }

        private void ShowScrollBarDemo_Click(object sender, EventArgs e)
        {
            string nextDemoName = ShowScrollBarDemo.Tag as string;

            ChangeDemo.Fire(this, new ChangeDemoEventArgs(nextDemoName));
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroProgressBar1.BarStyle == MetroProgressBarStyle.Standard)
                metroProgressBar1.BarStyle = MetroProgressBarStyle.Marquee;
            else
                metroProgressBar1.BarStyle = MetroProgressBarStyle.Standard;
        }
    }
}
