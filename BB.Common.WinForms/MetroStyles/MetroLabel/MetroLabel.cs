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
    public class MetroLabel : Label, IThemedComponent
    {
        private bool scaleFont;
        private float minimumFontSize;
        private float maximumFontSize;

        public MetroLabel()
        {
            ScaleFont = false;
            MinimumFontSize = 13.0f;
            MaximumFontSize = 100.0f;
            Font = new Font("MS Reference Sans Serif", 13.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Size = new Size(138, 28);

            ThemeManager.RegisterComponent(this);

            OnLoad();
        }

        public virtual void ApplyTheme(BaseTheme newTheme)
        {
            ForeColor = newTheme.Colors["LabelForeground"];
        }

        protected void OnLoad()
        {
            var myEvent = Load;

            if (myEvent != null)
                myEvent(this, new EventArgs());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (scaleFont)
            {
                SizeF size;
                using (Font f2 = AppropriateFont(e.Graphics, minimumFontSize, maximumFontSize, ClientRectangle.Size, Text, Font, out size))
                {
                    PointF p = new PointF((ClientRectangle.Width - size.Width) / 2,
                        (ClientRectangle.Height - size.Height) / 2);

                    using (Brush textBrush = new SolidBrush(ForeColor))
                    {
                        e.Graphics.DrawString(Text, f2, textBrush, p);
                    }
                }
            }
            else
                base.OnPaint(e);
        }

        [Browsable(true)]
        [Bindable(true)]
        [Category("Font Scaling")]
        [Description("Specifies if the font should be scaled with the size of the MetroLabel.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(false)]
        public bool ScaleFont
        {
            get { return scaleFont; }
            set
            {
                if (value)
                {
                    scaleFont = value;

                    SetStyle(ControlStyles.ResizeRedraw, true);

                    Invalidate();
                }
            }
        }

        [Browsable(true)]
        [Bindable(true)]
        [Category("Font Scaling")]
        [Description("Specifies the minimum font size of the MetroLabel.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(13.0f)]
        public float MinimumFontSize
        {
            get { return minimumFontSize; }

            set
            {
                if (value > maximumFontSize)
                    MaximumFontSize = value;

                minimumFontSize = value;
            }
        }

        [Browsable(true)]
        [Bindable(true)]
        [Category("Font Scaling")]
        [Description("Specifies the maximum font size of the MetroLabel.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(100.0f)]
        public float MaximumFontSize
        {
            get { return maximumFontSize; }

            set
            {
                if (value < minimumFontSize)
                    MinimumFontSize = value;

                maximumFontSize = value;
            }
        }

        public static Font AppropriateFont(Graphics g, float minFontSize,
            float maxFontSize, Size layoutSize, string s, Font f, out SizeF extent)
        {
            if (maxFontSize == minFontSize)
                f = new Font(f.FontFamily, minFontSize, f.Style);

            extent = g.MeasureString(s, f);

            if (maxFontSize <= minFontSize)
                return f;

            float hRatio = layoutSize.Height / extent.Height;
            float wRatio = layoutSize.Width / extent.Width;
            float ratio = (hRatio < wRatio) ? hRatio : wRatio;

            float newSize = f.Size * ratio;

            if (newSize < minFontSize)
                newSize = minFontSize;
            else if (newSize > maxFontSize)
                newSize = maxFontSize;

            f = new Font(f.FontFamily, newSize, f.Style);
            extent = g.MeasureString(s, f);

            return f;
        }

        public event EventHandler Load;
    }
}
