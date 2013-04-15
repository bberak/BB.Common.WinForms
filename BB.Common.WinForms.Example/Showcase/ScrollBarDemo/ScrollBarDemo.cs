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
    public partial class ScrollBarDemo : MetroUserControl, IDemo
    {
        public ScrollBarDemo()
        {
            InitializeComponent();

            metroScrollBar1.BindTo(innerPanel, metroPanel1);
        }

        public event EventHandler<ChangeDemoEventArgs> ChangeDemo;

        public string DemoName
        {
            get { return "MetroScrollBarDemo"; }
        }

        public Control GetControl()
        {
            return this;
        }

        private void ShowProgressDemo_Click(object sender, EventArgs e)
        {
            string nextDemoName = ShowProgressDemo.Tag as string;

            ChangeDemo.Fire(this, new ChangeDemoEventArgs(nextDemoName));
        }

        private void ShowSliders_Click(object sender, EventArgs e)
        {
            string nextDemoName = ShowSliders.Tag as string;

            ChangeDemo.Fire(this, new ChangeDemoEventArgs(nextDemoName));
        }
    }
}
