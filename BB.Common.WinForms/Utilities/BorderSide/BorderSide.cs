using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BB.Common.WinForms
{
    [Serializable]
    public class BorderSide
    {
        private int width;
        private Color color;

        public BorderSide()
        {
            width = 2;
            color = Color.Black;
        }

        public int Width
        {
            get { return width; }
            set
            {
                if (width != value)
                {
                    width = value;

                    OnBorderSideChanged();
                }
            }
        }

        public Color Color
        {
            get { return color; }
            set
            {
                if (color != value)
                {
                    color = value;

                    OnBorderSideChanged();
                }
            }
        }

        protected void OnBorderSideChanged()
        {
            var myEvent = BorderSideChanged;

            if (myEvent != null)
                myEvent(this, new EventArgs());
        }

        public event EventHandler BorderSideChanged;
    }
}
