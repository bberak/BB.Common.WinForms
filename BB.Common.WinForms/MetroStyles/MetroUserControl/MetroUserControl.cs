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
    public partial class MetroUserControl : UserControl, IThemedComponent
    {
        public bool IsOptimized { get; protected set; }

        public MetroUserControl()
            :this(false)
        {
        }

        public MetroUserControl(bool optimize)
        {
            InitializeComponent();

            Size = new Size(850, 490);

            IsOptimized = optimize;

            if (optimize)
            {
                //-- http://www.codeproject.com/KB/graphics/DoubleBuffering.aspx
                SetStyle(ControlStyles.UserPaint |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw, true);
            }

            ThemeManager.RegisterComponent(this);
        }

        public virtual void ApplyTheme(BaseTheme newTheme)
        {
            BackColor = newTheme.Colors["UserControlBackground"];
        }
    }
}
