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
    [DesignerAttribute(typeof(MetroButtonDesigner))]
    public class MetroButton : Button, IThemedComponent
    {
        private Color mouseOverForeColor;
        private Color prevForeColor;
        private Color borderColor;
        private Color mouseOverBorderColor;
        private int borderWidth;

        public bool IsMouseOver { get; protected set; }

        public MetroButton()
        {
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;   
            TabStop = false;
            UseVisualStyleBackColor = false;
            Size = new Size(105, 30);
            Font = new Font("MS Reference Sans Serif", 13.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Margin = new Padding(0);

            ThemeManager.RegisterComponent(this);

            OnLoad();
        }

        public virtual void ApplyTheme(BaseTheme newTheme)
        {
            BorderWidth = newTheme.Units["ButtonBorderWidth"];
            ForeColor = newTheme.Colors["ButtonForeground"];
            BackColor = newTheme.Colors["ButtonBackground"];
            MouseOverBackColor = newTheme.Colors["ButtonMouseOverBackground"];
            MouseDownBackColor = newTheme.Colors["ButtonMouseDownBackground"];
            MouseOverForeColor = newTheme.Colors["ButtonMouseOverForeground"];
            BorderColor = newTheme.Colors["ButtonBorder"];
            MouseOverBorderColor = newTheme.Colors["ButtonMouseOverBorder"];   
        }

        [Browsable(true)]
        [Bindable(true)]
        [Category("Appearance")]
        [Description("Specifies the mouse-over foreground color of the MetroButton.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "Black")]
        public Color MouseOverForeColor
        {
            get { return mouseOverForeColor; }

            set
            {
                if (mouseOverForeColor != value)
                {
                    mouseOverForeColor = value;
                }
            }
        }

        [Browsable(true)]
        [Bindable(true)]
        [Category("Appearance")]
        [Description("Specifies the mouse-down background color of the MetroButton.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "Silver")]
        public Color MouseDownBackColor
        {
            get { return FlatAppearance.MouseDownBackColor; }

            set
            {
                if (FlatAppearance.MouseDownBackColor != value)
                {
                    FlatAppearance.MouseDownBackColor = value;
                }
            }
        }

        [Browsable(true)]
        [Bindable(true)]
        [Category("Appearance")]
        [Description("Specifies the mouse-over background color of the MetroButton.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "Silver")]
        public Color MouseOverBackColor
        {
            get { return FlatAppearance.MouseOverBackColor; }

            set
            {
                if (FlatAppearance.MouseOverBackColor != value)
                {
                    FlatAppearance.MouseOverBackColor = value;
                }
            }
        }

        [Browsable(true)]
        [Bindable(true)]
        [Category("Appearance")]
        [Description("Specifies the border color of the MetroButton.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "Black")]
        public Color BorderColor
        {
            get { return borderColor; }

            set
            {
                if (borderColor != value)
                {
                    borderColor = value;

                    Invalidate();
                }
            }
        }

        [Browsable(true)]
        [Bindable(true)]
        [Category("Appearance")]
        [Description("Specifies the mouse-over border color of the MetroButton.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "Black")]
        public Color MouseOverBorderColor
        {
            get { return mouseOverBorderColor; }

            set
            {
                if (mouseOverBorderColor != value)
                {
                    mouseOverBorderColor = value;

                    Invalidate();
                }
            }
        }

        [Browsable(true)]
        [Bindable(true)]
        [Category("Appearance")]
        [Description("Specifies the border width of the MetroButton.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(2)]
        public int BorderWidth 
        {
            get { return borderWidth; }
            set
            {
                if (borderWidth != value)
                {
                    borderWidth = value;

                    Invalidate();
                }
            }
        }

        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            IsMouseOver = true;

            prevForeColor = ForeColor;

            ForeColor = mouseOverForeColor;

            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            IsMouseOver = false;

            ForeColor = prevForeColor;

            base.OnMouseLeave(e);
        }

        //-- http://stackoverflow.com/questions/148729/how-to-set-change-remove-focus-style-on-a-button-in-c
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //-- Get the current border color
            Color color;

            if (IsMouseOver)
                color = mouseOverBorderColor;
            else
                color = borderColor;

            //-- Method below didn't work quite that well for me.. I think pens will draw down the theoretical middle
            //-- of the rectangle's borders or something.. Have to read up on this..
            //-- Draw Border using color specified in Flat Appearance (however, I'm not using flat appearance..)
            //Pen pen = new Pen(color, BorderWidth);
            //Rectangle rectangle = new Rectangle(borderWidth, borderWidth, Size.Width - borderWidth, Size.Height - borderWidth);
            //e.Graphics.DrawRectangle(pen, rectangle);

            //-- This method worked quite well (I think I just need to understand how pens work..
            //-- I use this same technique in the MetroPanel's OnPaint method..
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid);
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
