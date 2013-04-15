using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BB.Common.WinForms
{
    [Serializable]
    public class Border
    {
        public BorderSide All { get; protected set; }
        public BorderSide Left { get; protected set; }
        public BorderSide Top { get; protected set; }
        public BorderSide Right { get; protected set; }
        public BorderSide Bottom { get; protected set; }

        public Border()
        {
            All = new BorderSide();
            All.BorderSideChanged += new EventHandler(BorderSideChanged);

            Left = new BorderSide();
            Left.BorderSideChanged += new EventHandler(BorderSideChanged);

            Top = new BorderSide();
            Top.BorderSideChanged += new EventHandler(BorderSideChanged);

            Right = new BorderSide();
            Right.BorderSideChanged += new EventHandler(BorderSideChanged);

            Bottom = new BorderSide();
            Bottom.BorderSideChanged += new EventHandler(BorderSideChanged);
        }

        void BorderSideChanged(object sender, EventArgs e)
        {
            if (All == (BorderSide)sender)
            {
                UpdateSides(All.Width, All.Color);
            }

            var myEvent = BorderChanged;

            if (myEvent != null)
                BorderChanged(this, e);
        }

        protected void UpdateSides(int w, Color c)
        {
            Left.Width = w;
            Left.Color = c;

            Top.Width = w;
            Top.Color = c;

            Right.Width = w;
            Right.Color = c;

            Bottom.Width = w;
            Bottom.Color = c;
        }

        public event EventHandler BorderChanged;
    }
}
