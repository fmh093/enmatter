using System.Drawing;

namespace Enmatter.Design
{
    public static class Colors
    {
        public static class Background
        {
            public static Color Black = Color.FromArgb(0, 0, 0);
            public static Color VeryDarkGrey = Color.FromArgb(12, 12, 12);
            public static Color DarkGrey = Color.FromArgb(18, 18, 18);
            public static Color Grey  = Color.FromArgb(24, 24, 24);
            public static Color LightGrey = Color.FromArgb(48, 48, 48);
            public static Color Red = Color.FromArgb(20, 0, 0);
            public static Color RichTextBoxDefault = Grey;
        }

        public static class Foreground
        {
            public static Color White = Color.FromArgb(255, 255, 255);
            public static Color WhiteGrey = Color.FromArgb(220, 220, 220);
            public static Color Black = Color.FromArgb(0, 0, 0);
            public static Color Header = Color.FromArgb(57, 170, 214);
            public static Color RichTextBoxDefault = WhiteGrey;
        }
    }
}
