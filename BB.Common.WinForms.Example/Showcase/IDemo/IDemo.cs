using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BB.Common.WinForms.Example
{
    interface IDemo
    {
        event EventHandler<ChangeDemoEventArgs> ChangeDemo;

        string DemoName { get; }

        Control GetControl();
    }
}
