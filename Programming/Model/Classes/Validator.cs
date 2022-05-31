using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Предоставляет методы для проверки данных.
    /// </summary>
    public static class Validator
    {

        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="property">Имя значения.</param>
        /// <exception cref="ArgumentException">Ошибка, когда число меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(string property, int value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Значение поля {property} должно быть положительным");
            }
        }

        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="property">Имя значения.</param>
        /// <exception cref="ArgumentException">Ошибка, когда число меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(string property, double value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Значение поля {property} должно быть положительным");
            }
        }

        /// <summary>
        ///  Проверяет, что число лежит в диапазоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <param name="fieldName">Имя значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(int value, int min, int max, string fieldName)
        {
            if ((value > max || value < min))
            {
                throw new ArgumentException($"Введите корректное значение от 0 до 60 {fieldName}");
            }
        }

        /// <summary>
        /// Проверяет, что число лежит в диапозоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Левая границы диапозона.</param>
        /// <param name="max">Праваяграницы диапозона.</param>
        /// <param name="fieldName">Имя значения.</param>
        public static void AssertValueInRange(double value, double min, double max, string fieldName)
        {
            if ((value > max || value <  min))
            {
                throw new ArgumentException($"Введите корректное значение от 0 до 60 {fieldName}");
            }
        }

        /// <summary>
        /// Проверяет, что строка состоит только из букв.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="fieldName">Имя значения.</param>
        /// <exception cref="ArgumentException">Ошибка, когда в строке есть цифры.</exception>
        public static void AssertStringContainsOnlyLetters(string value, string fieldName)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsLetter(value[i]) != true)
                {
                    throw new ArgumentException($"Введите только буквы {fieldName}");
                }
            }
        }
    }
}
