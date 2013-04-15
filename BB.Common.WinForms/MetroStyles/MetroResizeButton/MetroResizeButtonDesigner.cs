using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.Design;

namespace BB.Common.WinForms
{
    public class MetroResizeButtonDesigner : ControlDesigner
    {
        protected override void PreFilterProperties(System.Collections.IDictionary properties)
        {
            base.PreFilterProperties(properties);

            properties.Remove("FlatStyle");

            properties.Remove("FlatAppearance");
        }
    }
}
