namespace BB.Common.WinForms
{
    partial class MetroTextBox
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
            this.InnerPanel = new BB.Common.WinForms.MetroPanel();
            this.InnerTextBox = new BB.Common.WinForms.SizeableTextBox();
            this.InnerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InnerPanel
            // 
            this.InnerPanel.BackColor = System.Drawing.Color.White;
            this.InnerPanel.BorderColor = System.Drawing.Color.White;
            this.InnerPanel.Controls.Add(this.InnerTextBox);
            this.InnerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerPanel.Location = new System.Drawing.Point(0, 0);
            this.InnerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.InnerPanel.Name = "InnerPanel";
            this.InnerPanel.Padding = new System.Windows.Forms.Padding(2);
            this.InnerPanel.Size = new System.Drawing.Size(220, 57);
            this.InnerPanel.TabIndex = 0;
            // 
            // InnerTextBox
            // 
            this.InnerTextBox.BackColor = System.Drawing.Color.White;
            this.InnerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InnerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InnerTextBox.Location = new System.Drawing.Point(2, 2);
            this.InnerTextBox.Name = "InnerTextBox";
            this.InnerTextBox.Size = new System.Drawing.Size(216, 53);
            this.InnerTextBox.TabIndex = 0;
            this.InnerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InnerTextBox_KeyPress);
            // 
            // MetroTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InnerPanel);
            this.Name = "MetroTextBox";
            this.Size = new System.Drawing.Size(220, 57);
            this.InnerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroPanel InnerPanel;
        private SizeableTextBox InnerTextBox;

    }
}
