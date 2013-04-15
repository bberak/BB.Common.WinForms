using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace BB.Common.WinForms
{
    [ToolboxItem(true)]
    public class SizeableTextBox : TextBox
    {
        public SizeableTextBox()
        {
            AutoSize = false;
        }

        [Browsable(true)]
        [Bindable(true)]
        [Description("Gets or sets the auto size property of the textbox.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(false)]
        public override bool AutoSize
        {
            get { return base.AutoSize; }

            set { base.AutoSize = value; }
        }
    }
}
