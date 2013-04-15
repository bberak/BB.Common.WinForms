namespace BB.Common.WinForms
{
    partial class MetroSlidingControl
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Canvas = new BB.Common.WinForms.MetroPanel();
            this.TitleButton = new BB.Common.WinForms.MetroButton();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BorderColor = System.Drawing.Color.White;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Margin = new System.Windows.Forms.Padding(0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Padding = new System.Windows.Forms.Padding(2);
            this.Canvas.Size = new System.Drawing.Size(469, 490);
            this.Canvas.TabIndex = 0;
            // 
            // TitleButton
            // 
            this.TitleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.TitleButton.BorderColor = System.Drawing.Color.White;
            this.TitleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleButton.ForeColor = System.Drawing.Color.White;
            this.TitleButton.Location = new System.Drawing.Point(0, 0);
            this.TitleButton.Margin = new System.Windows.Forms.Padding(0);
            this.TitleButton.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.TitleButton.MouseOverBackColor = System.Drawing.Color.Coral;
            this.TitleButton.MouseOverBorderColor = System.Drawing.Color.White;
            this.TitleButton.MouseOverForeColor = System.Drawing.Color.White;
            this.TitleButton.Name = "TitleButton";
            this.TitleButton.Size = new System.Drawing.Size(469, 30);
            this.TitleButton.TabIndex = 1;
            this.TitleButton.TabStop = false;
            this.TitleButton.Text = "Menu Title";
            this.TitleButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TitleButton.UseVisualStyleBackColor = false;
            this.TitleButton.Click += new System.EventHandler(this.TitleButton_Click);
            // 
            // MetroSlidingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.TitleButton);
            this.Controls.Add(this.Canvas);
            this.Name = "MetroSlidingControl";
            this.Size = new System.Drawing.Size(469, 490);
            this.ResumeLayout(false);

        }

        #endregion

        protected MetroPanel Canvas;
        protected MetroButton TitleButton;



    }
}
