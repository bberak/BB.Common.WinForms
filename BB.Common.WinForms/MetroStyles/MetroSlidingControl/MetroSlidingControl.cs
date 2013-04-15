using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Transitions;

namespace BB.Common.WinForms
{
    //-- http://stackoverflow.com/questions/1356676/c-sharp-user-control-as-a-custom-panel
    //-- Allow control to be added to the InnerPanel and changed to be made to the TitleButton.
    [ToolboxItem(true)]
    [Designer(typeof(MetroSlidingControlDesigner))]
    public partial class MetroSlidingControl : MetroUserControl
    {
        [Browsable(true)]
        [Bindable(true)]
        [Category("Movement")]
        [Description("Specifies the vertical movement distance of the MetroSlidingControl.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(150)]
        public int VerticalMovementDistance { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public MetroButton Button { get { return TitleButton; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public MetroPanel Panel { get { return Canvas; }}

        public bool IsPackedAway { get; protected set; }

        public MetroSlidingControl()
        {
            InitializeComponent();

            IsPackedAway = true;
            VerticalMovementDistance = 150;
        }

        private void TitleButton_Click(object sender, EventArgs e)
        {
            if (IsPackedAway)
            {
                Transition.run(this, "Top", Top - VerticalMovementDistance, new TransitionType_EaseInEaseOut(300));
                IsPackedAway = false;
            }
            else
            {
                Transition.run(this, "Top", Top + VerticalMovementDistance, new TransitionType_EaseInEaseOut(300));
                IsPackedAway = true;
            }
        }
    }
}
