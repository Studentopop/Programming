using System.Drawing;

namespace Programming.View
{
    /// <summary>
    /// Хранит в себе значения цветов приложении.
    /// </summary>
    public class AppColors
    {
        public static readonly Color SpringColor = Color.LightGreen;

        public static readonly Color AutumnColor = Color.Orange;

        public static readonly Color SummerColor = Color.White;

        public static readonly Color WinterColor = Color.White;

        public static readonly Color currentBackColor = Color.White;

        public static readonly Color errorBackColor = Color.Pink;

        public static readonly Color intersect = Color.FromArgb(127, 255, 127, 127);

        public static readonly Color unIntersect = Color.FromArgb(127, 127, 255, 127);
    }
}
