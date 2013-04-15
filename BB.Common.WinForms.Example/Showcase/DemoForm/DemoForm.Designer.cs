namespace BB.Common.WinForms.Example
{
    partial class DemoForm
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
            this.FlowMenu = new BB.Common.WinForms.MetroFlowMenu();
            this.Canvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(64, 12);
            this.DefaultToolTip.SetToolTip(this.ExitButton, "Close");
            // 
            // MinimizeButton
            // 
            this.DefaultToolTip.SetToolTip(this.MinimizeButton, "Minimize");
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Canvas.Controls.Add(this.FlowMenu);
            this.Canvas.Size = new System.Drawing.Size(1104, 558);
            this.Canvas.Controls.SetChildIndex(this.TitleBarPanel, 0);
            this.Canvas.Controls.SetChildIndex(this.StatusBarPanel, 0);
            this.Canvas.Controls.SetChildIndex(this.FlowMenu, 0);
            // 
            // StatusBarPanel
            // 
            this.StatusBarPanel.Location = new System.Drawing.Point(0, 532);
            this.StatusBarPanel.Size = new System.Drawing.Size(1104, 26);
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.Size = new System.Drawing.Size(1104, 42);
            // 
            // ToggleFullscreenButton
            // 
            this.ToggleFullscreenButton.Location = new System.Drawing.Point(35, 12);
            this.DefaultToolTip.SetToolTip(this.ToggleFullscreenButton, "Toggle Fullscreen");
            // 
            // FlowMenu
            // 
            this.FlowMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.FlowMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowMenu.Location = new System.Drawing.Point(0, 42);
            this.FlowMenu.Margin = new System.Windows.Forms.Padding(0);
            this.FlowMenu.Name = "FlowMenu";
            this.FlowMenu.Size = new System.Drawing.Size(1104, 490);
            this.FlowMenu.TabIndex = 5;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 562);
            this.Name = "DemoForm";
            this.Text = "Form1";
            this.Canvas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFlowMenu FlowMenu;
    }
}