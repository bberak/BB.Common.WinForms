using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.Design;

namespace BB.Common.WinForms
{
    public class MetroPanelDesigner : ScrollableControlDesigner
    {
        protected override void PreFilterProperties(System.Collections.IDictionary properties)
        {
            base.PreFilterProperties(properties);

            properties.Remove("BorderStyle");
        }
    }
}
