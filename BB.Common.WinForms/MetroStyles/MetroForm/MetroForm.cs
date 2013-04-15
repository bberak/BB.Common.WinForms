using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BB.Common.WinForms
{
    public partial class MetroForm : Form, IThemedComponent
    {
        //-- Dragging Form
        private Point DragOffset;
        private bool IsMouseDown = false;

        //-- Resizing Form
        private Point StartPos;
        private bool IsResizing = false;
        private Size StartSize;

        //-- Maximizing and Restoring Form
        private Point LastPos;
        private Size LastSize;

        public MetroForm()
        {
            InitializeComponent();

            RegisterForDragFeedback(this);
            RegisterForDragFeedback(Canvas);
            RegisterForDragFeedback(TitleBarPanel);
            RegisterForDragFeedback(WindowControlsPanel);
            RegisterForDragFeedback(StatusBarPanel);
            RegisterForDragFeedback(ResizeHandlePanel);

            RegisterForResizeFeedback(ResizeButton);

            RegisterForFullscreenToggle(this);
            RegisterForFullscreenToggle(Canvas);
            RegisterForFullscreenToggle(TitleBarPanel);
            RegisterForFullscreenToggle(StatusBarPanel);

            //-- Investigate this further.. I don't need the SupportsTransparentBackColor flag..
            //-- Do I only need to apply this here? Does it perform better if applied to individual controls..
            //-- http://stackoverflow.com/questions/4690426/why-do-my-winforms-controls-flicker-and-resize-slowly
            Resize += new EventHandler(MetroForm_Resize);
            SetStyle(ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer | 
                ControlStyles.SupportsTransparentBackColor,
                true);

            ThemeManager.RegisterComponent(this);
        }

        public virtual void ApplyTheme(BaseTheme newTheme)
        {
            //-- Remember, the Canvas covers the MetroForm, except the edges..
            Padding = new Padding(newTheme.Units["FormBorderWidth"]);
            BackColor = newTheme.Colors["FormBorder"];
            Canvas.BackColor = newTheme.Colors["FormBackground"];
        }

        private void MetroForm_Resize(object sender, EventArgs e)
        {
            this.Update();
        }

        public virtual void RegisterForDragFeedback(Control ctrl)
        {
            ctrl.MouseDown += new MouseEventHandler(OnMouseDown);
            ctrl.MouseMove += new MouseEventHandler(OnMouseMove);
            ctrl.MouseUp += new MouseEventHandler(OnMouseUp);
        }

        public virtual void RegisterForResizeFeedback(Control ctrl)
        {
            ctrl.MouseDown += new MouseEventHandler(OnResizeHandleMouseDown);
            ctrl.MouseMove += new MouseEventHandler(OnResizeHandleMouseMove);
            ctrl.MouseUp += new MouseEventHandler(OnResizeHandleMouseUp);
        }

        public virtual void RegisterForFullscreenToggle(Control ctrl)
        {
            ctrl.DoubleClick += new EventHandler(OnDoubleClick);
        }

        protected virtual void OnMouseUp(object sender, MouseEventArgs e)
        {
            // Changes the isMouseDown field so that the form does
            // not move unless the user is pressing the left mouse button.
            if (e.Button == MouseButtons.Left && IsMouseDown)
            {
                IsMouseDown = false;
            }
        }

        protected virtual void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(DragOffset.X, DragOffset.Y);
                Location = mousePos;
            }
        }

        protected virtual void OnMouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                //-- Lines below are for windows with border and title bars..
                //xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                //yOffset = -e.Y - SystemInformation.CaptionHeight -
                //    SystemInformation.FrameBorderSize.Height;

                //-- Make sure the dragging works with nested controls..
                //Control source = (Control)sender;

                // Obtain screen location of drag event...
                //Point screen = source.PointToScreen(new Point(e.X, e.Y));
        
                // And convert it to our local (form's) coordinate system...
                //Point local = PointToClient(screen);

                //-- I think this is the most efficient way, since it does not
                //-- involve casting and unnecessary calculations..
                Point local = PointToClient(Control.MousePosition);

                xOffset = -local.X;
                yOffset = -local.Y;
                DragOffset = new Point(xOffset, yOffset);
                IsMouseDown = true;
            }
        }

        protected virtual void OnResizeHandleMouseUp(object sender, MouseEventArgs e)
        {
            // Changes the isMouseDown field so that the form does
            // not move unless the user is pressing the left mouse button.
            if (e.Button == MouseButtons.Left && IsResizing)
            {
                IsResizing = false;
            }
        }

        protected virtual void OnResizeHandleMouseMove(object sender, MouseEventArgs e)
        {
            if (IsResizing)
            {
                Point mousePos = Control.MousePosition;
                Point newPosition = new Point(mousePos.X - StartPos.X, mousePos.Y - StartPos.Y);
                Size = new Size(StartSize.Width + newPosition.X, StartSize.Height + newPosition.Y);
            }
        }

        protected virtual void OnResizeHandleMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                StartPos = Control.MousePosition;
                IsResizing = true;
                StartSize = Size;
            }
        }

        private void OnDoubleClick(object sender, EventArgs e)
        {
            ToggleFullscreen();
        }

        private void ToggleFullscreen()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Location = LastPos;
                Size = LastSize;
                WindowState = FormWindowState.Normal;
                ResizeButton.Visible = true;
            }
            else
            {
                LastPos = Location;
                LastSize = Size;
                WindowState = FormWindowState.Maximized;
                ResizeButton.Visible = false;
            }
        }

        protected virtual void OnExitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected virtual void OnMinimizeButtonClicked(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        protected virtual void OnToggleFullscreenButtonClicked(object sender, EventArgs e)
        {
            ToggleFullscreen();
        }

        protected virtual void ShowControl(Control ctrl, bool visible)
        {
            ctrl.UpdateProperty<bool>("Visible", visible);

            Invalidate();
        }
    }
}
