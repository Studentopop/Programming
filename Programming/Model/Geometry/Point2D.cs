namespace Programming.Model.Classes
{

    /// <summary>
    /// Хранит данные о координатах фигуры.
    /// </summary>
    public class Point2D
    {

        /// <summary>
        /// Координата точки X.
        /// </summary>
        private int _x;


        /// <summary>
        /// Координата точки Y.
        /// </summary>
        private int _y;


        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата x. Должна быть неотрицательным числом.</param>
        /// <param name="y">Координата y. Должна быть неотрицательным числом.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }


        /// <summary>
        /// Возвращает и задаёт значение координату X. Должна быть неотрицательным числом.
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(X), value);
                _x = value;
            }
        }


        /// <summary>
        /// Возвращает и задаёт координату y. Должна быть неотрицательным числом.
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Y), value);
                _y = value;
            }
        }
    }
}