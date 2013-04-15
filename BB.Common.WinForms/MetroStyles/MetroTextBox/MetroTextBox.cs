using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BB.Common.WinForms
{
    [ToolboxItem(true)]
    [DesignerAttribute(typeof(MetroTextBoxDesigner))]
    public partial class MetroTextBox : UserControl, IThemedComponent
    {
        private Font defaultFont;
        private int leftIndent;
        private int topIndent;

        public MetroTextBox()
        {
            InitializeComponent();

            LeftIndent = 3;
            TopIndent = 2;
            defaultFont = new Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBoxFont = defaultFont;

            this.Click += new EventHandler(MetroTextBox_Click);
            InnerPanel.Click += new EventHandler(MetroTextBox_Click);
            InnerTextBox.GotFocus += new EventHandler(InnerTextBox_GotFocus);

            ThemeManager.RegisterComponent(this);
        }

        public virtual void ApplyTheme(BaseTheme newTheme)
        {
            BorderColor = newTheme.Colors["TextBoxBorder"];
            BackColor = newTheme.Colors["TextBoxBackground"];
            InnerTextBox.ForeColor = newTheme.Colors["TextBoxForeground"];
        }

        private void InnerTextBox_GotFocus(object sender, EventArgs e)
        {
            OnGotFocus(e);
        }

        private void MetroTextBox_Click(object sender, EventArgs e)
        {
            InnerTextBox.Select();
        }

        private void InnerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void RepositionTextBox()
        {
            if (InnerTextBox != null)
            {
                InnerTextBox.Top = TopIndent;
                InnerTextBox.Left = LeftIndent;

                InnerTextBox.Size = new Size(InnerPanel.ClientRectangle.Width - LeftIndent - InnerPanel.BorderWidth, 
                    InnerPanel.ClientRectangle.Height - TopIndent - InnerPanel.BorderWidth);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            RepositionTextBox();
        }

        [Browsable(true)]
        [Bindable(true)]
        [Description("Gets or sets the password char property of the textbox.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public char PasswordChar
        {
            get { return InnerTextBox.PasswordChar; }

            set { InnerTextBox.PasswordChar = value; Invalidate(); }
        }

        [Browsable(true)]
        [Bindable(true)]
        [Category("Indentation")]
        [Description("Gets or sets the left indent property of the textbox.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(3)]
        public int LeftIndent
        {
            get { return leftIndent; }

            set
            {
                if (leftIndent != value)
                {
                    leftIndent = value;

                    RepositionTextBox();

                    Invalidate();
                }
            }
               
        }

        [Browsable(true)]
        [Bindable(true)]
        [Category("Indentation")]
        [Description("Gets or sets the top indent property of the textbox.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(2)]
        public int TopIndent
        {
            get { return topIndent; }

            set
            {
                if (topIndent != value)
                {
                    topIndent = value;

                    RepositionTextBox();

                    Invalidate();
                }
            }
        }

        [Browsable(true)]
        [Bindable(true)]
        [Category("Border Options")]
        [Description("Specifies the border color of the MetroTextBox.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "Black")]
        public Color BorderColor
        {
            get { return InnerPanel.BorderColor; }

            set { InnerPanel.BorderColor = value; }
        }


        [Browsable(true)]
        [Bindable(true)]
        [Description("Gets or sets the text property of the textbox.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("")]
        public override string Text
        {
            get { return InnerTextBox.Text; }

            set
            {
                if (InnerTextBox.Text.Equals(value) == false)
                {
                    InnerTextBox.Text = value;

                    Invalidate();
                }
            }
        }

        [Browsable(true)]
        [Bindable(true)]
        [Description("Gets or sets the color property of the textbox.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "White")]
        public override Color BackColor
        {
            get
            {
                return InnerPanel.BackColor;
            }
            set
            {
                if (InnerPanel.BackColor != value)
                {
                    InnerPanel.BackColor = value;
                    InnerTextBox.BackColor = value;

                    Invalidate();
                }
            }
        }

        //[Browsable(true)]
        //[Bindable(true)]
        //[Description("Gets or sets the font property of the MetroTextBox.")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        //[DefaultValue(typeof(Font), "MS Reference Sans Serif, 15.75pt")]
        //public Font TextBoxFont
        //{
        //    get
        //    {
        //        return InnerTextBox.Font;
        //    }
        //    set
        //    {
        //        InnerTextBox.Font = value;

        //        Invalidate();
        //    }
        //}

        public Font TextBoxFont
        {
            get
            {
                return InnerTextBox.Font;
            }
            set
            {
                InnerTextBox.Font = value;

                Invalidate();
            }
        }

        public bool ShouldSerializeTextBoxFont()
        {
            return defaultFont != InnerTextBox.Font;
        }

        public void ResetTextBoxFont()
        {
            TextBoxFont = defaultFont;
        }
    }
}
