﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPractics.Services
{ /// <summary>
  /// Хранит данные о вызываемых цветах.
  /// </summary>
    public static class AppColor
    {
        /// <summary>
        /// Цвет некорректного значения.
        /// </summary> 
        public static System.Drawing.Color ErrorColor = System.Drawing.Color.LightPink;

        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        public static System.Drawing.Color CorrectColor = System.Drawing.Color.White;
    }
}
