using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BB.Common.WinForms.Example
{
    public class ChangeDemoEventArgs : EventArgs
    {
        public string DemoName { get; protected set; }

        public ChangeDemoEventArgs(string demoName)
        {
            DemoName = demoName;
        }
    }
}
