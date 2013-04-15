using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BB.Common.WinForms
{
    [ToolboxItem(false)]
    public class MetroProgressBarSegment : Panel, IThemedComponent
    {
        public int BorderWidth { get; protected set; }

        public Color BorderColor { get; protected set; }

        public MetroProgressBarSegment()
        {
            //-- Forces a redraw when resizing, therefore the previous borders don't hang on the screen
            //-- when resizing occurs..
            SetStyle(ControlStyles.ResizeRedraw, true);

            ThemeManager.RegisterComponent(this);

            OnLoad();
        }

        public virtual void ApplyTheme(BaseTheme newTheme)
        {
            BorderWidth = newTheme.Units["ProgressBarBorderWidth"];
            BorderColor = newTheme.Colors["ProgressBarBorder"];
            BackColor = newTheme.Colors["ProgressBarSegment"];
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                BorderColor, BorderWidth, ButtonBorderStyle.Solid,
                BorderColor, 0, ButtonBorderStyle.Solid,
                BorderColor, BorderWidth, ButtonBorderStyle.Solid,
                BorderColor, 0, ButtonBorderStyle.Solid);
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
