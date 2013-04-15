using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BB.Common.WinForms
{
    public interface IThemedComponent
    {
        void ApplyTheme(BaseTheme newTheme);

        event EventHandler Load;
    }
}
