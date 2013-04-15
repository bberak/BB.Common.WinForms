using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing;
using System.ComponentModel;

namespace BB.Common.WinForms
{
    [ToolboxItem(true)]
    [DesignerAttribute(typeof(MetroResizeButtonDesigner))]
    public class MetroResizeButton : MetroButton
    {
        public override void ApplyTheme(BaseTheme newTheme)
        {
            BorderWidth = newTheme.Units["ResizeButtonBorderWidth"];
            ForeColor = newTheme.Colors["ResizeButtonForeground"];
            BackColor = newTheme.Colors["ResizeButtonBackground"];
            MouseOverBackColor = newTheme.Colors["ResizeButtonMouseOverBackground"];
            MouseDownBackColor = newTheme.Colors["ResizeButtonMouseDownBackground"];
            MouseOverForeColor = newTheme.Colors["ResizeButtonMouseOverForeground"];
            BorderColor = newTheme.Colors["ResizeButtonBorder"];
            MouseOverBorderColor = newTheme.Colors["ResizeButtonMouseOverBorder"]; ;
        }
    }
}
