using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    class Validator
    {
        /// <summary>
        ///  Проверяет, что число лежит в диапазоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <param name="fieldName">Имя значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(double value, int min, int max, string fieldName)
        {
            if ((value > max || value < min))
            {
                throw new ArgumentException($"Введите корректное значение от 0 до 60" +
                    $" {fieldName}");
            }
        }

        /// <summary>
        /// Проверяет, что строка не превышает максимальную длину.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="maxLength">Верхняя граница диапазона.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает,когда значение 
        /// превыщает заданный диапазон.</exception>
        public static void AssertLengthString(string value,
                                              int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"Строка превышает максимальную длину: " +
                                            $"{maxLength} в поле {propertyName}.");
            }
        }

        /// <summary>
        /// Проверяет строку на определенную длину.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="length">>Длина на которую проверяется строка.</param>
        /// <param name="propertyName">Имя свойства или объекта,
        /// которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, когда
        /// длина строки не равна определенной длине.</exception>
        public static void AssertStringLength(int value, int length, string propertyName)
        {
            if (value.ToString().Length != length)
            {
                throw new ArgumentException($"Некорректная длина поле {propertyName}." +
                    $" Необходимая длина = {length}");
            }
        }

    }
}
