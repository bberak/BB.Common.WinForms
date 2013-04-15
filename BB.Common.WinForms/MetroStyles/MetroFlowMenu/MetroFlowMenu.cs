using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Transitions;

namespace BB.Common.WinForms
{
    public partial class MetroFlowMenu : MetroUserControl
    {
        private List<MetroMenuItem> MenuItems;

        private MetroMenuItem CurrentlyFocused;

        public MetroFlowMenu()
        {
            InitializeComponent();

            MenuItems = new List<MetroMenuItem>();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        public void AddMenuItem(MetroMenuItem newItem)
        {
            //-- Resize the control to be in line with the container..
            newItem.Control.Size = this.Size;

            MenuItems.Add(newItem);

            this.Invoke(delegate()
            {
                Controls.Add(newItem.Control);
            });

            //-- If this is the first menu item - it is focused by default.
            if (MenuItems.Count == 1)
            {
                CurrentlyFocused = newItem;
            }
            else //-- Greater than 1
            {
                //-- Don't want this control to resize as it's not in focus..
                //-- Better performance this way..
                newItem.Control.Invoke(delegate()
                {
                    newItem.Control.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                });
            }
        }

        public void ShowMenu(string menuName)
        {
            if (menuName.Equals(CurrentlyFocused.Name))
                return;

            MetroMenuItem target = GetMenuItem(menuName);

            if (target == null)
                throw new InvalidOperationException("Menu by the name of " + menuName + " could not be found..");

            this.Invoke(delegate()
            {
                //-- Don't want this control resize as it's losing focus..
                CurrentlyFocused.Control.Anchor = AnchorStyles.Left | AnchorStyles.Top;

                //-- Should I also make it invisible? Will this improve performance? Since technically the control doesn't have
                //-- to be drawn..
                //CurrentlyFocused.Control.Visible = false;

                //-- Make sure the control that will be focused is the same size as the parent.
                target.Control.Size = this.Size;

                //-- Definitely want this control to resize with the parent now - it's in focus!
                target.Control.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;

                if (target.MenuTransition == MetroMenuTransition.Instant)
                {
                    target.Control.Left = 0;                          
                    target.Control.BringToFront();
                }
                else if (target.MenuTransition == MetroMenuTransition.EaseIn)
                {
                    int direction = 1;

                    if (MenuItems.IndexOf(target) < MenuItems.IndexOf(CurrentlyFocused))
                        direction = -1;

                    target.Control.Left = this.Width * direction;
                    target.Control.BringToFront();

                    Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                    t.add(target.Control, "Left", 0);
                    t.add(CurrentlyFocused.Control, "Left", -this.Width * direction);
                    t.run();
                }
            });

            CurrentlyFocused = target;  
        }

        public bool Contains(string menuName)
        {
            return GetMenuItem(menuName) != null;
        }

        private MetroMenuItem GetMenuItem(string menuName)
        {
            MetroMenuItem findMe = MenuItems.Find(x => x.Name.Equals(menuName));

            return findMe;
        }
    }
}
