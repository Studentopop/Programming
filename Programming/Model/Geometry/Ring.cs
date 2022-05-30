using System;

namespace Programming.Model.Classes
{

    /// <summary>
    /// Хранит данные об кольце.
    /// </summary>
    public class Ring
    {

        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Внутренный радиус кольца.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>
        /// </summary>
        /// <param name="center">Координата центра кольца.</param>
        /// <param name="outerRadius">Внешний радиус.</param>
        /// <param name="innerRadius">Внутренний радиус.</param>
        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;

        }

        /// <summary>
        /// Возвращает и задаёт координаты центра.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задаёт размер внешнего радиуса.
        /// Должен быть неотрицательным числом. Должен быть больше внутреннего радиуса.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(nameof(OuterRadius),value);
                Validator.AssertValueInRange(value, _innerRadius, _outerRadius, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт размер внутреннего радиуса.
        /// Должен быть неотрицательным числом. Должен быть больше внешнего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(nameof(InnerRadius),value);
                Validator.AssertValueInRange(value, 0, _innerRadius, nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площадь.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (_outerRadius * _outerRadius - _innerRadius * _innerRadius);
            }
        }
    }
}