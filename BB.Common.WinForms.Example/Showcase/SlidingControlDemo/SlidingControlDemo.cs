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
    public partial class SlidingControlDemo : MetroUserControl, IDemo
    {
        public SlidingControlDemo()
        {
            InitializeComponent();
        }

        public event EventHandler<ChangeDemoEventArgs> ChangeDemo;

        public string DemoName
        {
            get { return "MetroSlidingControlDemo"; }
        }

        public Control GetControl()
        {
            return this;
        }

        private void ShowScrollBars_Click(object sender, EventArgs e)
        {
            string nextDemoName = ShowScrollBars.Tag as string;

            ChangeDemo.Fire(this, new ChangeDemoEventArgs(nextDemoName));
        }
    }
}
