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
    public partial class TextBoxDemo : MetroUserControl, IDemo
    {
        public TextBoxDemo()
        {
            InitializeComponent();
        }

        public event EventHandler<ChangeDemoEventArgs> ChangeDemo;

        public string DemoName
        {
            get { return "MetroTextBoxDemo"; }
        }

        private void ShowButtons_Click(object sender, EventArgs e)
        {
            string nextDemoName = ShowButtons.Tag as string;

            ChangeDemo.Fire(this, new ChangeDemoEventArgs(nextDemoName));
        }


        public Control GetControl()
        {
            return this;
        }
    }
}
