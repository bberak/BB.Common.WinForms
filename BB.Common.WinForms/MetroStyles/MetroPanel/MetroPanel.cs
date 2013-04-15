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
    [DesignerAttribute(typeof(MetroPanelDesigner))]
    public class MetroPanel : Panel, IThemedComponent
    {
        private int borderWidth;
        private Color borderColor;

        public MetroPanel()
        {
            Margin = new Padding(0);

            //-- http://www.codeproject.com/KB/graphics/DoubleBuffering.aspx
            //-- Forces a redraw when resizing, therefore the previous borders don't hang on the screen
            //-- when resizing occurs..
            //SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw, true);

            ThemeManager.RegisterComponent(this);

            OnLoad();
        }

        public virtual void ApplyTheme(BaseTheme newTheme)
        {
            BorderWidth = newTheme.Units["PanelBorderWidth"];
            BorderColor = newTheme.Colors["PanelBorder"];
        }

        [Browsable(true)]
        [Bindable(true)]
        [Category("Border Options")]
        [Description("Specifies the border width of the MetroPanel.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(2)]
        public int BorderWidth
        {
            get { return borderWidth; }

            set
            {
                if (value != borderWidth)
                {
                    borderWidth = value;

                    //-- I don't really see a point in change the padding here...
                    //Padding = new Padding(borderWidth);

                    Invalidate();

                    //--http://stackoverflow.com/questions/1852829/i-want-to-make-a-panel-have-a-thick-border-can-i-set-this-somehow
                    //PerformLayout();
                }
            }
        }

        [Browsable(true)]
        [Bindable(true)]
        [Category("Border Options")]
        [Description("Specifies the border color of the MetroPanel.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "Black")]
        public Color BorderColor
        {
            get { return borderColor; }

            set { borderColor = value; Invalidate(); }
        }

        //-- http://bytes.com/topic/visual-basic-net/answers/373547-paint-event-panel
        //public override Rectangle DisplayRectangle
        //{
        //    get
        //    {
        //        //-- My code works pretty well I think...
        //        Rectangle rect = new Rectangle(Padding.Left,
        //            Padding.Top,
        //            Width - Padding.Left - Padding.Right,
        //            Height - Padding.Top - Padding.Bottom);
        //        //Rectangle rect = ClientRectangle;
        //        //Size borderSize = new Size(BorderWidth, BorderWidth);
        //        //Size borderSize = new Size(Padding.Left, Padding.Top);
        //        //rect.Inflate(borderSize.Width * -1, borderSize.Height * -1);
        //        return rect;
        //    }
        //}

        //--http://stackoverflow.com/questions/1852829/i-want-to-make-a-panel-have-a-thick-border-can-i-set-this-somehow
        //-- I did make some edits though..
        public override Rectangle DisplayRectangle
        {
            get
            {
                return new Rectangle(borderWidth,
                    borderWidth,
                    Width - Padding.Left - Padding.Right - borderWidth * 2,
                    Height - Padding.Top - Padding.Bottom - borderWidth * 2);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid);

            //--http://stackoverflow.com/questions/1852829/i-want-to-make-a-panel-have-a-thick-border-can-i-set-this-somehow
            //base.OnPaintBackground(e);
            //if (true)
            //{
            //    using (Pen p = new Pen(borderColor, borderWidth))
            //    {
            //        Rectangle r = ClientRectangle;
            //        // now for the funky stuff...
            //        // to get the rectangle drawn correctly, we actually need to 
            //        // adjust the rectangle as .net centers the line, based on width, 
            //        // on the provided rectangle.
            //        r.Inflate(-Convert.ToInt32(borderWidth / 2.0 + .5), -Convert.ToInt32(borderWidth / 2.0 + .5));
            //        e.Graphics.DrawRectangle(p, r);
            //    }
            //}
        }

        //-- This is the same as the "SetStyle(ControlStyles.ResizeRedraw, true);" loc in the constructor..
        //-- http://vicky4147.wordpress.com/2007/03/04/how-to-draw-a-custom-border-around-a-form-or-control/
        //protected override void OnResize(EventArgs eventargs)
        //{
        //    base.OnResize(eventargs);

        //    Invalidate();
        //}

        //--http://stackoverflow.com/questions/1852829/i-want-to-make-a-panel-have-a-thick-border-can-i-set-this-somehow
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetDisplayRectLocation(borderWidth, borderWidth);
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);

            Invalidate();
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
