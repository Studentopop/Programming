using System;
using Rectangle = Programming.Model.Classes.Rectangle;
using Point2D = Programming.Model.Classes.Point2D;
    
namespace Programming.Model.Geometry
{

    /// <summary>
    /// Статический класс создания прямоугольников.
    /// </summary>
    public static class RectangleFactory
    {

        /// <summary>
        /// Создаёт прямоугольник со случайными значениями.  <see cref="Rectangle"/>.
        /// </summary>  
        /// <returns>Возвращает экземпляр класса <see cref="Rectangle"/>.</returns>
        public static Rectangle Randomize()
        {
            Random random = new Random();
            var rectangleHeight = random.Next(0, 200);
            var rectangleWidth = random.Next(0, 100);
            var rectangleX = random.Next(0, 425);
            var rectangleY = random.Next(0, 425);
            var rectanglePosition = new Point2D(rectangleX, rectangleY);

            return new Rectangle(rectangleHeight,rectangleWidth,"Green",rectanglePosition);
        }
    }
}