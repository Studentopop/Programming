﻿using System.Drawing;

namespace Programming.View
{
    /// <summary>
    /// Хранит в себе значения цветов приложении.
    /// </summary>
    public static class AppColors
    {
        public static readonly Color SpringColor = Color.LightGreen;

        public static readonly Color AutumnColor = Color.Orange;

        public static readonly Color SummerColor = Color.White;

        public static readonly Color WinterColor = Color.White;

        public static readonly Color CurrentBackColor = Color.White;

        public static readonly Color ErrorBackColor = Color.Pink;

        public static readonly Color CollisionColor = Color.FromArgb(127, 255, 127, 127);

        public static readonly Color NotCollisionColor = Color.FromArgb(127, 127, 255, 127);
    }
}
