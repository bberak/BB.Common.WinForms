namespace BB.Common.WinForms.Example
{
    partial class ScrollBarDemo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ShowProgressDemo = new BB.Common.WinForms.MetroButton();
            this.metroPanel1 = new BB.Common.WinForms.MetroPanel();
            this.innerPanel = new System.Windows.Forms.Panel();
            this.metroLabel7 = new BB.Common.WinForms.MetroLabel();
            this.metroLabel6 = new BB.Common.WinForms.MetroLabel();
            this.metroLabel5 = new BB.Common.WinForms.MetroLabel();
            this.metroLabel4 = new BB.Common.WinForms.MetroLabel();
            this.metroLabel3 = new BB.Common.WinForms.MetroLabel();
            this.metroLabel2 = new BB.Common.WinForms.MetroLabel();
            this.metroLabel1 = new BB.Common.WinForms.MetroLabel();
            this.metroScrollBar1 = new BB.Common.WinForms.MetroScrollBar();
            this.ShowSliders = new BB.Common.WinForms.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.innerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowProgressDemo
            // 
            this.ShowProgressDemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ShowProgressDemo.BorderColor = System.Drawing.Color.White;
            this.ShowProgressDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowProgressDemo.ForeColor = System.Drawing.Color.White;
            this.ShowProgressDemo.Location = new System.Drawing.Point(73, 460);
            this.ShowProgressDemo.Margin = new System.Windows.Forms.Padding(0);
            this.ShowProgressDemo.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.ShowProgressDemo.MouseOverBackColor = System.Drawing.Color.Coral;
            this.ShowProgressDemo.MouseOverBorderColor = System.Drawing.Color.White;
            this.ShowProgressDemo.MouseOverForeColor = System.Drawing.Color.White;
            this.ShowProgressDemo.Name = "ShowProgressDemo";
            this.ShowProgressDemo.Size = new System.Drawing.Size(210, 30);
            this.ShowProgressDemo.TabIndex = 2;
            this.ShowProgressDemo.TabStop = false;
            this.ShowProgressDemo.Tag = "MetroProgressBarDemo";
            this.ShowProgressDemo.Text = "ProgressBar Demo";
            this.ShowProgressDemo.UseVisualStyleBackColor = false;
            this.ShowProgressDemo.Click += new System.EventHandler(this.ShowProgressDemo_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderColor = System.Drawing.Color.White;
            this.metroPanel1.Controls.Add(this.innerPanel);
            this.metroPanel1.Location = new System.Drawing.Point(73, 78);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(700, 297);
            this.metroPanel1.TabIndex = 1;
            // 
            // innerPanel
            // 
            this.innerPanel.BackColor = System.Drawing.Color.Transparent;
            this.innerPanel.Controls.Add(this.metroLabel7);
            this.innerPanel.Controls.Add(this.metroLabel6);
            this.innerPanel.Controls.Add(this.metroLabel5);
            this.innerPanel.Controls.Add(this.metroLabel4);
            this.innerPanel.Controls.Add(this.metroLabel3);
            this.innerPanel.Controls.Add(this.metroLabel2);
            this.innerPanel.Controls.Add(this.metroLabel1);
            this.innerPanel.Location = new System.Drawing.Point(2, 2);
            this.innerPanel.Name = "innerPanel";
            this.innerPanel.Size = new System.Drawing.Size(696, 396);
            this.innerPanel.TabIndex = 0;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel7.ForeColor = System.Drawing.Color.White;
            this.metroLabel7.Location = new System.Drawing.Point(27, 352);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(138, 28);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "metroLabel7";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(27, 299);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(138, 28);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "metroLabel6";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(27, 242);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(138, 28);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "metroLabel5";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(27, 180);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(138, 28);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "metroLabel4";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(27, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(138, 28);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "metroLabel3";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(27, 70);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(138, 28);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "metroLabel2";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(27, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(138, 28);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.Location = new System.Drawing.Point(787, 78);
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Size = new System.Drawing.Size(19, 297);
            this.metroScrollBar1.TabIndex = 0;
            // 
            // ShowSliders
            // 
            this.ShowSliders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ShowSliders.BorderColor = System.Drawing.Color.White;
            this.ShowSliders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSliders.ForeColor = System.Drawing.Color.White;
            this.ShowSliders.Location = new System.Drawing.Point(669, 460);
            this.ShowSliders.Margin = new System.Windows.Forms.Padding(0);
            this.ShowSliders.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.ShowSliders.MouseOverBackColor = System.Drawing.Color.Coral;
            this.ShowSliders.MouseOverBorderColor = System.Drawing.Color.White;
            this.ShowSliders.MouseOverForeColor = System.Drawing.Color.White;
            this.ShowSliders.Name = "ShowSliders";
            this.ShowSliders.Size = new System.Drawing.Size(181, 30);
            this.ShowSliders.TabIndex = 3;
            this.ShowSliders.TabStop = false;
            this.ShowSliders.Tag = "MetroSlidingControlDemo";
            this.ShowSliders.Text = "Sliders Demo";
            this.ShowSliders.UseVisualStyleBackColor = false;
            this.ShowSliders.Click += new System.EventHandler(this.ShowSliders_Click);
            // 
            // ScrollBarDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowSliders);
            this.Controls.Add(this.ShowProgressDemo);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroScrollBar1);
            this.Name = "ScrollBarDemo";
            this.metroPanel1.ResumeLayout(false);
            this.innerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroPanel metroPanel1;
        private MetroScrollBar metroScrollBar1;
        private MetroButton ShowProgressDemo;
        private System.Windows.Forms.Panel innerPanel;
        private MetroLabel metroLabel7;
        private MetroLabel metroLabel6;
        private MetroLabel metroLabel5;
        private MetroLabel metroLabel4;
        private MetroLabel metroLabel3;
        private MetroLabel metroLabel2;
        private MetroLabel metroLabel1;
        private MetroButton ShowSliders;

    }
}
