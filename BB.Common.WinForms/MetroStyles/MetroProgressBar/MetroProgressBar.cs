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
    public partial class MetroProgressBar : UserControl, IThemedComponent
    {
        private Timer MarqueeTimer;

        private int MarqueeX;

        private int MarqueeWidth;

        private MetroProgressBarStyle barStyle;
    
        private int value;

        public int Maximum { get; set; }

        public int Value
        {
            get { return value; }

            set
            {
                if (this.value != value)
                { 
                    this.value = value;
                    if (ProgressBarSegment != null)
                        Draw();
                }
            }
        }

        public int BorderWidth { get; set; }

        public MetroProgressBarStyle BarStyle 
        {
            get { return barStyle; }
            set
            {
                barStyle = value;

                if (barStyle == MetroProgressBarStyle.Standard)
                {
                    MarqueeTimer.Stop();
                }
                else
                {
                    MarqueeX = 0;

                    CalculateMarqueeWidth();

                    MarqueeTimer.Start();
                }

                if (ProgressBarSegment != null)
                    Draw();
            }
        }

        public MetroProgressBar()
        {
            Maximum = 100;

            Value = 50;

            MarqueeTimer = new Timer();
            MarqueeTimer.Tick += new EventHandler(MarqueeTimer_Tick);
            MarqueeTimer.Interval = 16;

            BarStyle = MetroProgressBarStyle.Standard;

            InitializeComponent();

            ThemeManager.RegisterComponent(this);

            Draw();
        }

        public virtual void ApplyTheme(BaseTheme newTheme)
        {
            BorderWidth = newTheme.Units["ProgressBarBorderWidth"];
            BackColor = newTheme.Colors["ProgressBarBorder"];
            InnerPanel.BackColor = newTheme.Colors["ProgressBarBackground"];
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (Visible == false)
                MarqueeTimer.Stop();
        }

        private void Draw()
        {
            if (BarStyle == MetroProgressBarStyle.Standard || DesignMode)
                DrawStandard();
            else
                DrawMarquee();
        }

        private void DrawStandard()
        {
            ProgressBarSegment.Location = new Point(-BorderWidth, 0);

            ProgressBarSegment.Size = new Size(GetProgressWidth(), InnerPanel.Size.Height);

            Invalidate();
        }

        private int GetProgressWidth()
        {
            int total = Size.Width;

            double perc = Value / (double)Maximum;

            int progress = Convert.ToInt32(total * perc);

            return progress;
        }

        private void DrawMarquee()
        {
            ProgressBarSegment.Location = new Point(MarqueeX, 0);

            ProgressBarSegment.Size = new Size(MarqueeWidth, InnerPanel.Size.Height);

            Invalidate();
        }

        private void CalculateMarqueeWidth()
        {
            MarqueeWidth = Convert.ToInt32(Size.Width * 0.2);
        }

        private void MarqueeTimer_Tick(object sender, EventArgs e)
        {
            MarqueeX += 6;

            if (MarqueeX > Size.Width)
                MarqueeX = 0 - MarqueeWidth;

            Draw();

            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            //-- Uncomment if you want the marquee segment to resize as the control resizes
            //if (BarStyle == Style.Marquee)
            //    CalculateMarqueeWidth();
            
            Draw();

            base.OnResize(e);    
        }
    }
}
