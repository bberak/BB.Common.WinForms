using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BB.Common.WinForms
{
    public abstract class BaseTheme
    {
        public Dictionary<string, Color> Colors { get; protected set; }
        public Dictionary<string, Brush> Brushes { get; protected set; }       
        public Dictionary<string, Pen> Pens { get; protected set; }
        public Dictionary<string, int> Units { get; protected set; }
        public abstract string Name { get; }

        public BaseTheme()
        {
            Colors = new Dictionary<string, Color>();
            Brushes = new Dictionary<string, Brush>();    
            Pens = new Dictionary<string, Pen>();
            Units = new Dictionary<string, int>();

            LoadProperties();
        }

        protected abstract void LoadProperties();

        public void AddColor(string name, Color color)
        {
            Colors[name] = color;
        }

        public void AddBrush(string name, Brush brush)
        {
            Brushes[name] = brush;
        }

        public void AddPen(string name, Pen pen)
        {
            Pens[name] = pen;
        }

        public void AddUnit(string name, int unit)
        {
            Units[name] = unit;
        }
    }
}
