using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BB.Common.WinForms
{
    public class MetroToolTip : ToolTip, IThemedComponent
    {
        public event EventHandler Load;

        public MetroToolTip()
        {
            ThemeManager.RegisterComponent(this);

            OnLoad();
        }

        protected virtual void OnLoad()
        {
            Load.Fire(this, new EventArgs());
        }

        public virtual void ApplyTheme(BaseTheme newTheme)
        {
            BackColor = newTheme.Colors["ToolTipBackground"];
            ForeColor = newTheme.Colors["ToolTipForeground"];
            InitialDelay = newTheme.Units["ToolTipInitialDelay"];
            AutoPopDelay = newTheme.Units["ToolTipPopDelay"];
            ReshowDelay = newTheme.Units["ToolTipReshowDelay"];
        }
    }
}
