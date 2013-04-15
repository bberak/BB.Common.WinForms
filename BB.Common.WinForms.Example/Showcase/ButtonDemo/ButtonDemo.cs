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
    public partial class ButtonDemo : MetroUserControl, IDemo
    {
        public ButtonDemo()
        {
            InitializeComponent();
        }

        public event EventHandler<ChangeDemoEventArgs> ChangeDemo;

        public string DemoName
        {
            get { return "MetroButtonDemo"; }
        }

        private void ShowTextBoxes_Click(object sender, EventArgs e)
        {
            string nextDemoName = ShowTextBoxes.Tag as string;

            ChangeDemo.Fire(this, new ChangeDemoEventArgs(nextDemoName));
        }

        private void ShowProgressBar_Click(object sender, EventArgs e)
        {
            string nextDemoName = ShowProgressBar.Tag as string;

            ChangeDemo.Fire(this, new ChangeDemoEventArgs(nextDemoName));
        }


        public Control GetControl()
        {
            return this;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops, haven't implemented this click event yet!");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops, haven't implemented this click event yet!");
        }
    }
}
