namespace BB.Common.WinForms
{
    partial class MetroForm
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
            this.Canvas = new System.Windows.Forms.Panel();
            this.StatusBarPanel = new System.Windows.Forms.Panel();
            this.ResizeHandlePanel = new System.Windows.Forms.Panel();
            this.ResizeButton = new BB.Common.WinForms.MetroResizeButton();
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.WindowControlsPanel = new System.Windows.Forms.Panel();
            this.ToggleFullscreenButton = new BB.Common.WinForms.MetroButton();
            this.MinimizeButton = new BB.Common.WinForms.MetroButton();
            this.ExitButton = new BB.Common.WinForms.MetroButton();
            this.DefaultToolTip = new BB.Common.WinForms.MetroToolTip();
            this.Canvas.SuspendLayout();
            this.StatusBarPanel.SuspendLayout();
            this.ResizeHandlePanel.SuspendLayout();
            this.TitleBarPanel.SuspendLayout();
            this.WindowControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.Controls.Add(this.StatusBarPanel);
            this.Canvas.Controls.Add(this.TitleBarPanel);
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(2, 2);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(715, 380);
            this.Canvas.TabIndex = 3;
            // 
            // StatusBarPanel
            // 
            this.StatusBarPanel.Controls.Add(this.ResizeHandlePanel);
            this.StatusBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusBarPanel.Location = new System.Drawing.Point(0, 354);
            this.StatusBarPanel.Name = "StatusBarPanel";
            this.StatusBarPanel.Size = new System.Drawing.Size(715, 26);
            this.StatusBarPanel.TabIndex = 4;
            // 
            // ResizeHandlePanel
            // 
            this.ResizeHandlePanel.Controls.Add(this.ResizeButton);
            this.ResizeHandlePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ResizeHandlePanel.Location = new System.Drawing.Point(690, 0);
            this.ResizeHandlePanel.Name = "ResizeHandlePanel";
            this.ResizeHandlePanel.Size = new System.Drawing.Size(25, 26);
            this.ResizeHandlePanel.TabIndex = 0;
            // 
            // ResizeButton
            // 
            this.ResizeButton.BackColor = System.Drawing.Color.White;
            this.ResizeButton.BorderColor = System.Drawing.Color.White;
            this.ResizeButton.BorderWidth = 0;
            this.ResizeButton.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.ResizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ResizeButton.Location = new System.Drawing.Point(10, 11);
            this.ResizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.ResizeButton.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.ResizeButton.MouseOverBackColor = System.Drawing.Color.Coral;
            this.ResizeButton.MouseOverBorderColor = System.Drawing.Color.White;
            this.ResizeButton.MouseOverForeColor = System.Drawing.Color.White;
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(14, 14);
            this.ResizeButton.TabIndex = 0;
            this.ResizeButton.TabStop = false;
            this.ResizeButton.UseVisualStyleBackColor = false;
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.Controls.Add(this.WindowControlsPanel);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(715, 42);
            this.TitleBarPanel.TabIndex = 3;
            // 
            // WindowControlsPanel
            // 
            this.WindowControlsPanel.Controls.Add(this.ToggleFullscreenButton);
            this.WindowControlsPanel.Controls.Add(this.MinimizeButton);
            this.WindowControlsPanel.Controls.Add(this.ExitButton);
            this.WindowControlsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.WindowControlsPanel.Location = new System.Drawing.Point(617, 0);
            this.WindowControlsPanel.Name = "WindowControlsPanel";
            this.WindowControlsPanel.Size = new System.Drawing.Size(98, 42);
            this.WindowControlsPanel.TabIndex = 4;
            // 
            // ToggleFullscreenButton
            // 
            this.ToggleFullscreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ToggleFullscreenButton.BorderColor = System.Drawing.Color.White;
            this.ToggleFullscreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleFullscreenButton.ForeColor = System.Drawing.Color.White;
            this.ToggleFullscreenButton.Location = new System.Drawing.Point(33, 12);
            this.ToggleFullscreenButton.Margin = new System.Windows.Forms.Padding(0);
            this.ToggleFullscreenButton.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.ToggleFullscreenButton.MouseOverBackColor = System.Drawing.Color.Coral;
            this.ToggleFullscreenButton.MouseOverBorderColor = System.Drawing.Color.White;
            this.ToggleFullscreenButton.MouseOverForeColor = System.Drawing.Color.White;
            this.ToggleFullscreenButton.Name = "ToggleFullscreenButton";
            this.ToggleFullscreenButton.Size = new System.Drawing.Size(27, 26);
            this.ToggleFullscreenButton.TabIndex = 3;
            this.ToggleFullscreenButton.TabStop = false;
            this.ToggleFullscreenButton.Text = "+";
            this.DefaultToolTip.SetToolTip(this.ToggleFullscreenButton, "Toggle Fullscreen");
            this.ToggleFullscreenButton.UseVisualStyleBackColor = false;
            this.ToggleFullscreenButton.Click += new System.EventHandler(this.OnToggleFullscreenButtonClicked);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.MinimizeButton.BorderColor = System.Drawing.Color.White;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(6, 12);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.MinimizeButton.MouseOverBackColor = System.Drawing.Color.Coral;
            this.MinimizeButton.MouseOverBorderColor = System.Drawing.Color.White;
            this.MinimizeButton.MouseOverForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(27, 26);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Text = "-";
            this.DefaultToolTip.SetToolTip(this.MinimizeButton, "Minimize");
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.OnMinimizeButtonClicked);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ExitButton.BorderColor = System.Drawing.Color.White;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(60, 12);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.ExitButton.MouseOverBackColor = System.Drawing.Color.Coral;
            this.ExitButton.MouseOverBorderColor = System.Drawing.Color.White;
            this.ExitButton.MouseOverForeColor = System.Drawing.Color.White;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(27, 26);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "!";
            this.DefaultToolTip.SetToolTip(this.ExitButton, "Close");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.OnExitButtonClicked);
            // 
            // DefaultToolTip
            // 
            this.DefaultToolTip.AutoPopDelay = 5000;
            this.DefaultToolTip.InitialDelay = 500;
            this.DefaultToolTip.ReshowDelay = 100;
            // 
            // MetroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 384);
            this.Controls.Add(this.Canvas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MetroForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MetroForm";
            this.Canvas.ResumeLayout(false);
            this.StatusBarPanel.ResumeLayout(false);
            this.ResizeHandlePanel.ResumeLayout(false);
            this.TitleBarPanel.ResumeLayout(false);
            this.WindowControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected MetroButton ExitButton;
        protected MetroButton MinimizeButton;
        protected MetroResizeButton ResizeButton;
        private System.Windows.Forms.Panel ResizeHandlePanel;
        private System.Windows.Forms.Panel WindowControlsPanel;
        protected System.Windows.Forms.Panel Canvas;
        protected System.Windows.Forms.Panel StatusBarPanel;
        protected System.Windows.Forms.Panel TitleBarPanel;
        protected MetroButton ToggleFullscreenButton;
        protected MetroToolTip DefaultToolTip;
    }
}