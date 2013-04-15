namespace BB.Common.WinForms
{
    partial class MetroProgressBar
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
            this.InnerPanel = new System.Windows.Forms.Panel();
            this.ProgressBarSegment = new BB.Common.WinForms.MetroProgressBarSegment();
            this.InnerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InnerPanel
            // 
            this.InnerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.InnerPanel.Controls.Add(this.ProgressBarSegment);
            this.InnerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerPanel.Location = new System.Drawing.Point(2, 2);
            this.InnerPanel.Name = "InnerPanel";
            this.InnerPanel.Size = new System.Drawing.Size(603, 69);
            this.InnerPanel.TabIndex = 0;
            // 
            // ProgressBarSegment
            // 
            this.ProgressBarSegment.BackColor = System.Drawing.Color.Coral;
            this.ProgressBarSegment.Location = new System.Drawing.Point(32, 0);
            this.ProgressBarSegment.Name = "ProgressBarSegment";
            this.ProgressBarSegment.Size = new System.Drawing.Size(301, 69);
            this.ProgressBarSegment.TabIndex = 0;
            // 
            // MetroProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.InnerPanel);
            this.Name = "MetroProgressBar";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(607, 73);
            this.InnerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InnerPanel;
        private MetroProgressBarSegment ProgressBarSegment;


    }
}
