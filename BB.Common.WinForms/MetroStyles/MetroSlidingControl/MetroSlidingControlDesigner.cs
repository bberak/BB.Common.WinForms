using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms.Design;

namespace BB.Common.WinForms
{
    //-- http://stackoverflow.com/questions/1356676/c-sharp-user-control-as-a-custom-panel
    public class MetroSlidingControlDesigner : ParentControlDesigner
    {
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            MetroSlidingControl control = component as MetroSlidingControl;
            this.EnableDesignMode(control.Button, "Button");
            this.EnableDesignMode(control.Panel, "Panel");           
        }
    }
}
