using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BB.Common.WinForms
{
    public class JaffasTheme : BaseTheme
    {
        public override string Name
        {
            get { return "JaffasTheme"; }
        }

        protected override void LoadProperties()
        {
            AddColor("FormBorder", Color.FromArgb(255, 58, 58, 58));
            AddUnit("FormBorderWidth", 2);
            AddColor("FormBackground", Color.FromArgb(255, 102, 102, 102));
            AddColor("LabelForeground", Color.White);    
            AddColor("ButtonForeground", Color.White);
            AddColor("ButtonBackground", Color.FromArgb(255, 102, 102, 102));
            AddColor("ButtonBorder", Color.White);
            AddColor("ButtonMouseOverForeground", Color.White);
            AddColor("ButtonMouseOverBackground", Color.Coral);
            AddColor("ButtonMouseOverBorder", Color.White);
            AddColor("ButtonMouseDownBackground", Color.Tomato);
            AddUnit("ButtonBorderWidth", 2);
            AddColor("UserControlBackground", Color.FromArgb(255, 102, 102, 102));
            AddColor("PanelBorder", Color.White);
            AddUnit("PanelBorderWidth", 2);
            AddColor("ProgressBarSegment", Color.Coral);
            AddColor("ProgressBarBackground", Color.FromArgb(255, 102, 102, 102));
            AddColor("ProgressBarBorder", Color.White);
            AddUnit("ProgressBarBorderWidth", 2);
            AddBrush("ScrollBarBackground", new SolidBrush(Color.FromArgb(255, 102, 102, 102)));
            AddBrush("ScrollBarTrack", System.Drawing.Brushes.DarkGray);
            AddBrush("ScrollBarThumb", System.Drawing.Brushes.White);
            AddBrush("ScrollBarThumbHover", System.Drawing.Brushes.Coral);
            AddBrush("ScrollBarThumbPressed", System.Drawing.Brushes.Tomato);
            AddBrush("ScrollBarThumbGrip", System.Drawing.Brushes.Transparent);
            AddBrush("ScrollBarArrowButtons", System.Drawing.Brushes.White);
            AddBrush("ScrollBarArrowButtonsHover", System.Drawing.Brushes.Coral);
            AddBrush("ScrollBarArrowButtonsPressed", System.Drawing.Brushes.Tomato);
            AddPen("ScrollBarBorder", System.Drawing.Pens.Transparent);
            AddColor("TextBoxForeground", Color.White);
            AddColor("TextBoxBackground", Color.FromArgb(255, 58, 58, 58));
            AddColor("TextBoxBorder", Color.White);
            AddColor("ListItemMouseOverBackground", Color.Coral);
            AddColor("ListItemBorder", Color.White);
            AddColor("LinkLabelActiveLink", Color.Coral);
            AddColor("LinkLabelLink", Color.White);
            AddColor("LinkLabelVisitedLink", Color.White);
            AddColor("ResizeButtonForeground", Color.FromArgb(255, 102, 102, 102));
            AddColor("ResizeButtonBackground", Color.White);
            AddColor("ResizeButtonBorder", Color.White);
            AddColor("ResizeButtonMouseOverForeground", Color.White);
            AddColor("ResizeButtonMouseOverBackground", Color.Coral);
            AddColor("ResizeButtonMouseOverBorder", Color.White);
            AddColor("ResizeButtonMouseDownBackground", Color.Tomato);
            AddUnit("ResizeButtonBorderWidth", 2);
            AddColor("ToolTipBackground", SystemColors.Info);
            AddColor("ToolTipForeground", SystemColors.InfoText);
            AddUnit("ToolTipInitialDelay", 500);
            AddUnit("ToolTipPopDelay", 5000);
            AddUnit("ToolTipReshowDelay", 100);
        }
    }
}
