using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BB.Common.WinForms
{
    public interface IScrollBarRenderer
    {
        void DrawBackground(Graphics g, Rectangle rect, ScrollBarOrientation orientation);

        void DrawTrack(Graphics g, Rectangle rect, ScrollBarState state, ScrollBarOrientation orientation);

        void DrawThumb(Graphics g, Rectangle rect, ScrollBarState state, ScrollBarOrientation orientation);

        void DrawThumbGrip(Graphics g, Rectangle rect, ScrollBarOrientation orientation);

        void DrawArrowButton(Graphics g, Rectangle rect, ScrollBarArrowButtonState state, bool arrowUp, ScrollBarOrientation orientation);

        void DrawBorder(Graphics g, int width, int height, bool enabled);
    }
}
