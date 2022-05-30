namespace Programming.Model.Classes
{
    /// <summary>
    /// Прямоугольник с координатами центра, длиной и шириной.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Количество всех экземпляров класса.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Длина.
        /// </summary>
        private int _height;

        /// <summary>
        /// Ширина.
        /// </summary>
        private int _width;

        /// <summary>
        /// Уникальный индентификатор для всех экземпляров класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Возвращает и задает длину. Должна быть неотрицательным числом.
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Height), value);
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задает длину. Должна быть неотрицательным числом.
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);
                _width = value;
            }
        }

        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задает координаты центра.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает уникальный индентификатор экземпляра класса.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает количество всех экземпляров класса.
        /// </summary>
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">Длина прямоугольника. Положительное число.</param>
        /// <param name="width">Ширина прямоугольника. Положительное число.</param>
        /// <param name="center">Координаты прямоугольника.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        public Rectangle(double height, double width, string color, Point2D center)
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
            Height = (int)height;
            Width = (int)width;
            Color = color;
            Center = center;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/> по умолчанию.
        /// </summary>
        public Rectangle(double length, double width)
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }


        /// <summary>
        /// Информация о прямоугольнике.
        /// </summary>
        /// <returns>Строка вида id: (X; Y; Weight; Height)</returns>
        public string GetRectangleInfo()
        {
            return $"{_id}: (X={Center.X}; Y={Center.Y}; W={_width}; H={_height})";
        }
    }
}