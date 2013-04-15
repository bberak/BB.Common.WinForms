namespace BB.Common.WinForms.Example
{
    partial class TextBoxDemo
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
            this.metroTextBox1 = new BB.Common.WinForms.MetroTextBox();
            this.metroTextBox2 = new BB.Common.WinForms.MetroTextBox();
            this.metroTextBox3 = new BB.Common.WinForms.MetroTextBox();
            this.ShowButtons = new BB.Common.WinForms.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.metroTextBox1.BorderColor = System.Drawing.Color.White;
            this.metroTextBox1.Location = new System.Drawing.Point(100, 83);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.Size = new System.Drawing.Size(220, 30);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.TextBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.metroTextBox2.BorderColor = System.Drawing.Color.White;
            this.metroTextBox2.LeftIndent = 20;
            this.metroTextBox2.Location = new System.Drawing.Point(100, 164);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.Size = new System.Drawing.Size(334, 48);
            this.metroTextBox2.TabIndex = 1;
            this.metroTextBox2.Text = "metroTextBox2";
            this.metroTextBox2.TextBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.metroTextBox3.BorderColor = System.Drawing.Color.White;
            this.metroTextBox3.LeftIndent = 20;
            this.metroTextBox3.Location = new System.Drawing.Point(100, 269);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.Size = new System.Drawing.Size(526, 87);
            this.metroTextBox3.TabIndex = 2;
            this.metroTextBox3.Text = "metroTextBox3";
            this.metroTextBox3.TextBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ShowButtons
            // 
            this.ShowButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ShowButtons.BorderColor = System.Drawing.Color.White;
            this.ShowButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButtons.ForeColor = System.Drawing.Color.White;
            this.ShowButtons.Location = new System.Drawing.Point(694, 460);
            this.ShowButtons.Margin = new System.Windows.Forms.Padding(0);
            this.ShowButtons.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.ShowButtons.MouseOverBackColor = System.Drawing.Color.Coral;
            this.ShowButtons.MouseOverBorderColor = System.Drawing.Color.White;
            this.ShowButtons.MouseOverForeColor = System.Drawing.Color.White;
            this.ShowButtons.Name = "ShowButtons";
            this.ShowButtons.Size = new System.Drawing.Size(156, 30);
            this.ShowButtons.TabIndex = 3;
            this.ShowButtons.TabStop = false;
            this.ShowButtons.Tag = "MetroButtonDemo";
            this.ShowButtons.Text = "Button Demo";
            this.ShowButtons.UseVisualStyleBackColor = false;
            this.ShowButtons.Click += new System.EventHandler(this.ShowButtons_Click);
            // 
            // TextBoxDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowButtons);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Name = "TextBoxDemo";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroTextBox metroTextBox1;
        private MetroTextBox metroTextBox2;
        private MetroTextBox metroTextBox3;
        private MetroButton ShowButtons;
    }
}
