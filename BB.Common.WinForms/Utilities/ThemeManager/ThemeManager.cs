using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BB.Common.WinForms
{
    public static class ThemeManager
    {
        public static BaseTheme CurrentTheme { get; private set; }
        private static List<IThemedComponent> ThemedComponents;

        static ThemeManager()
        {
            CurrentTheme = new JaffasTheme();
            ThemedComponents = new List<IThemedComponent>();
        }

        public static void ApplyTheme(BaseTheme newTheme)
        {
            CurrentTheme = newTheme;

            foreach (IThemedComponent component in ThemedComponents)
                component.ApplyTheme(newTheme);

            OnThemeChanged();
        }

        public static void RegisterComponent(IThemedComponent component)
        {
            ThemedComponents.Add(component);

            component.Load += new EventHandler(component_Load);
        }

        static void component_Load(object sender, EventArgs e)
        {
            IThemedComponent component = sender as IThemedComponent;

            component.ApplyTheme(CurrentTheme);
        }

        private static void OnThemeChanged()
        {
            var myEvent = ThemeChanged;

            if (myEvent != null)
                ThemeChanged(CurrentTheme, new EventArgs());
        }

        public static event EventHandler ThemeChanged; 
    }
}
