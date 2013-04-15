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
    public class MetroMenuItem
    {
        public string Name { get; protected set; }

        public Control Control { get; protected set; }

        public MetroMenuTransition MenuTransition { get; protected set; }

        public MetroMenuItem(Control control, MetroMenuTransition transition, string name)
        {
            if (control == null)
                throw new InvalidOperationException("Control cannot be null.");

            Control = control;
            Control.Margin = new Padding(0);
            Control.Padding = new Padding(0);
            Control.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;

            if (string.IsNullOrEmpty(name))
                throw new InvalidOperationException("Name cannot be empty.");

            Name = name;

            MenuTransition = transition;
        }

        public override bool Equals(object obj)
        {
            if (obj is MetroMenuItem)
            {
                MetroMenuItem other = obj as MetroMenuItem;

                if (other.Name.Equals(Name))
                    return true;

                return false;
            }
            
            throw new InvalidOperationException("obj is not a MetroMenuItem");
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
