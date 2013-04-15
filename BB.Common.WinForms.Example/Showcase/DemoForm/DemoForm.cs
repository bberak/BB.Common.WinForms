using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BB.Common.WinForms.Example
{
    public partial class DemoForm : MetroForm
    {
        public DemoForm()
        {
            InitializeComponent();

            AddToMenu(new TextBoxDemo());
            AddToMenu(new ButtonDemo());
            AddToMenu(new ProgressBarDemo());
            AddToMenu(new ScrollBarDemo());
            AddToMenu(new SlidingControlDemo());
        }

        void AddToMenu(IDemo demo)
        {
            Control control = demo.GetControl();
            FlowMenu.AddMenuItem(new MetroMenuItem(control, MetroMenuTransition.EaseIn, demo.DemoName));
            demo.ChangeDemo += (o, e) => 
            { 
                FlowMenu.ShowMenu(e.DemoName); 
            };
            RegisterForDragFeedback(control);
        }
    }
}
