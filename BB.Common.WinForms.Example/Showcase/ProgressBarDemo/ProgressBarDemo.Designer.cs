namespace BB.Common.WinForms.Example
{
    partial class ProgressBarDemo
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
            this.metroButton1 = new BB.Common.WinForms.MetroButton();
            this.ShowButtons = new BB.Common.WinForms.MetroButton();
            this.metroProgressBar1 = new BB.Common.WinForms.MetroProgressBar();
            this.ShowScrollBarDemo = new BB.Common.WinForms.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroButton1.BorderColor = System.Drawing.Color.White;
            this.metroButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(515, 259);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(0);
            this.metroButton1.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.metroButton1.MouseOverBackColor = System.Drawing.Color.Coral;
            this.metroButton1.MouseOverBorderColor = System.Drawing.Color.White;
            this.metroButton1.MouseOverForeColor = System.Drawing.Color.White;
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(173, 30);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.TabStop = false;
            this.metroButton1.Text = "Change Behaviour";
            this.metroButton1.UseVisualStyleBackColor = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ShowButtons
            // 
            this.ShowButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ShowButtons.BorderColor = System.Drawing.Color.White;
            this.ShowButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButtons.ForeColor = System.Drawing.Color.White;
            this.ShowButtons.Location = new System.Drawing.Point(61, 460);
            this.ShowButtons.Margin = new System.Windows.Forms.Padding(0);
            this.ShowButtons.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.ShowButtons.MouseOverBackColor = System.Drawing.Color.Coral;
            this.ShowButtons.MouseOverBorderColor = System.Drawing.Color.White;
            this.ShowButtons.MouseOverForeColor = System.Drawing.Color.White;
            this.ShowButtons.Name = "ShowButtons";
            this.ShowButtons.Size = new System.Drawing.Size(139, 30);
            this.ShowButtons.TabIndex = 1;
            this.ShowButtons.TabStop = false;
            this.ShowButtons.Tag = "MetroButtonDemo";
            this.ShowButtons.Text = "Button Demo";
            this.ShowButtons.UseVisualStyleBackColor = false;
            this.ShowButtons.Click += new System.EventHandler(this.ShowButtons_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.BackColor = System.Drawing.Color.White;
            this.metroProgressBar1.BarStyle = BB.Common.WinForms.MetroProgressBarStyle.Standard;
            this.metroProgressBar1.BorderWidth = 2;
            this.metroProgressBar1.Location = new System.Drawing.Point(81, 220);
            this.metroProgressBar1.Maximum = 100;
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Padding = new System.Windows.Forms.Padding(2);
            this.metroProgressBar1.Size = new System.Drawing.Size(607, 17);
            this.metroProgressBar1.TabIndex = 0;
            this.metroProgressBar1.Value = 70;
            // 
            // ShowScrollBarDemo
            // 
            this.ShowScrollBarDemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ShowScrollBarDemo.BorderColor = System.Drawing.Color.White;
            this.ShowScrollBarDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowScrollBarDemo.ForeColor = System.Drawing.Color.White;
            this.ShowScrollBarDemo.Location = new System.Drawing.Point(652, 460);
            this.ShowScrollBarDemo.Margin = new System.Windows.Forms.Padding(0);
            this.ShowScrollBarDemo.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.ShowScrollBarDemo.MouseOverBackColor = System.Drawing.Color.Coral;
            this.ShowScrollBarDemo.MouseOverBorderColor = System.Drawing.Color.White;
            this.ShowScrollBarDemo.MouseOverForeColor = System.Drawing.Color.White;
            this.ShowScrollBarDemo.Name = "ShowScrollBarDemo";
            this.ShowScrollBarDemo.Size = new System.Drawing.Size(198, 30);
            this.ShowScrollBarDemo.TabIndex = 3;
            this.ShowScrollBarDemo.TabStop = false;
            this.ShowScrollBarDemo.Tag = "MetroScrollBarDemo";
            this.ShowScrollBarDemo.Text = "ScrollBar Demo";
            this.ShowScrollBarDemo.UseVisualStyleBackColor = false;
            this.ShowScrollBarDemo.Click += new System.EventHandler(this.ShowScrollBarDemo_Click);
            // 
            // ProgressBarDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowScrollBarDemo);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.ShowButtons);
            this.Controls.Add(this.metroProgressBar1);
            this.Name = "ProgressBarDemo";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroProgressBar metroProgressBar1;
        private MetroButton ShowButtons;
        private MetroButton metroButton1;
        private MetroButton ShowScrollBarDemo;
    }
}
