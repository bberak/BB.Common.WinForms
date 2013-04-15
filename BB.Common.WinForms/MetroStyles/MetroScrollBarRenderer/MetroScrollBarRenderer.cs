using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BB.Common.WinForms
{
    public class MetroScrollBarRenderer : IScrollBarRenderer, IThemedComponent
    {
        public Brush BackgroundBrush { get; set; }
        public Brush TrackBrush { get; set; }
        public Brush ThumbBrush { get; set; }
        public Brush ThumbHoverBrush { get; set; }
        public Brush ThumbPressedBrush { get; set; }
        public Brush ThumbGripBrush { get; set; }
        public Brush ArrowButtonsBrush { get; set; }
        public Brush ArrowButtonsHoverBrush { get; set; }
        public Brush ArrowButtonsPressedBrush { get; set; }
        public Pen BorderPen { get; set; }

        public MetroScrollBarRenderer()
        {
            ThemeManager.RegisterComponent(this);

            OnLoad();
        }

        public virtual void ApplyTheme(BaseTheme newTheme)
        {
            BackgroundBrush = newTheme.Brushes["ScrollBarBackground"];
            TrackBrush = newTheme.Brushes["ScrollBarTrack"];
            ThumbBrush = newTheme.Brushes["ScrollBarThumb"];
            ThumbHoverBrush = newTheme.Brushes["ScrollBarThumbHover"];
            ThumbPressedBrush = newTheme.Brushes["ScrollBarThumbPressed"];
            ThumbGripBrush = newTheme.Brushes["ScrollBarThumbGrip"];
            ArrowButtonsBrush = newTheme.Brushes["ScrollBarArrowButtons"];
            ArrowButtonsHoverBrush = newTheme.Brushes["ScrollBarArrowButtonsHover"];
            ArrowButtonsPressedBrush = newTheme.Brushes["ScrollBarArrowButtonsPressed"];
            BorderPen = newTheme.Pens["ScrollBarBorder"];
        }

        public void DrawBackground(Graphics g, Rectangle rect, ScrollBarOrientation orientation)
        {
            g.FillRectangle(BackgroundBrush, rect);
        }

        public void DrawTrack(Graphics g, Rectangle rect, ScrollBarState state, ScrollBarOrientation orientation)
        {
            g.FillRectangle(TrackBrush, rect);
        }

        public void DrawThumb(Graphics g, Rectangle rect, ScrollBarState state, ScrollBarOrientation orientation)
        {
            switch (state)
            {
                case ScrollBarState.Disabled:
                case ScrollBarState.Normal:
                case ScrollBarState.Active:
                    g.FillRectangle(ThumbBrush, rect);
                    break;

                case ScrollBarState.Pressed:
                    g.FillRectangle(ThumbPressedBrush, rect);
                    break;

                default:
                    g.FillRectangle(ThumbHoverBrush, rect);
                    break;
            }
        }

        public void DrawThumbGrip(Graphics g, Rectangle rect, ScrollBarOrientation orientation)
        {
            //-- Don't draw a grip.
            //g.FillRectangle(ThumbGripBrush, rect);
        }

        public void DrawArrowButton(Graphics g, Rectangle rect, ScrollBarArrowButtonState state, bool arrowUp, ScrollBarOrientation orientation)
        {
            switch (state)
            {
                case ScrollBarArrowButtonState.UpDisabled:
                case ScrollBarArrowButtonState.UpNormal:
                case ScrollBarArrowButtonState.UpActive:
                case ScrollBarArrowButtonState.DownDisabled:
                case ScrollBarArrowButtonState.DownNormal:
                case ScrollBarArrowButtonState.DownActive:
                    g.FillRectangle(ArrowButtonsBrush, rect);
                    break;

                case ScrollBarArrowButtonState.UpPressed:
                case ScrollBarArrowButtonState.DownPressed:
                    g.FillRectangle(ArrowButtonsPressedBrush, rect);
                    break;

                default:
                    g.FillRectangle(ArrowButtonsHoverBrush, rect);
                    break;
            }
        }

        public void DrawBorder(Graphics g, int width, int height, bool enabled)
        {
            //-- Don't draw a border.
            //g.DrawRectangle(BorderPen, 1, 1, width-2, height-2);
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
