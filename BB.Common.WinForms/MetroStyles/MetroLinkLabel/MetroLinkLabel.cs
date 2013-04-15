using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BB.Common.WinForms
{
    [ToolboxItem(true)]
    public class MetroLinkLabel : LinkLabel, IThemedComponent
    {
        public MetroLinkLabel()
        {
            Size = new Size(138, 28);

            Font = new Font("MS Reference Sans Serif", 13.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            ThemeManager.RegisterComponent(this);

            OnLoad();
        }

        public virtual void ApplyTheme(BaseTheme newTheme)
        {
            ActiveLinkColor = newTheme.Colors["LinkLabelActiveLink"];
            LinkColor = newTheme.Colors["LinkLabelLink"];
            VisitedLinkColor = newTheme.Colors["LinkLabelVisitedLink"];
        }

        protected void OnLoad()
        {
            var myEvent = Load;

            if (myEvent != null)
                myEvent(this, new EventArgs());
        }

        public event EventHandler Load;
    }
}
