using System;
using System.Text.RegularExpressions;

namespace ContactList.Model
{
    /// <summary>
    /// Предоставляет методы для проверки данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что строка не пустая в поле.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">
        /// Ошибка, когда в строке есть пустое значение.</exception>
        public static void AssertEmptyValue(string value, string propertyName)
        {
            if (value == "")
            {
                throw new ArgumentException($"Строка не может быть пустой " +
                                            $"в поле {propertyName}");
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
        /// Проверяет, что строка является ссылкой на пользователя VK.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, когда значение 
        /// не являетя ссылкой на VK.</exception>
        public static void IsUrlLink(string value, string propertyName)
        {
            if (!Regex.IsMatch(value, @"(https?:\/\/)?(www\.)?(vk.com\/)
                              (|[a-zA-z][a-zA-Z0-9_.]{2,})"))
            {
                throw new ArgumentException($"Должна быть ссылка на {propertyName}.");
            }
        }

        /// <summary>
        /// Проверяет, что строка является номером телефона.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, когда строка не начинается с "+"
        /// и не содержит 11 цифр.</exception>
        public static void IsPhoneNumber(string value, string propertyName)
        {
            if (!Regex.IsMatch(value, @"^(\+7[0-9]{9}[0-9]$)"))
            {
                throw new ArgumentException(
                    $" { propertyName} начинается с '+' и дальше идут 11 цифр.");
            }
        }

        /// <summary>
        /// Проверяет, что значение входит в заданный диапазон.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, когда значение
        /// превыщает заданный диапазон.</exception>
        public static void AssertValueInRange(int value, int max, string propertyName)
        {
            if (value > max)
            {
                throw new ArgumentException(
                    $" {propertyName} должно находиться в диапозоне до {max}");
            }
        }

        /// <summary>
        /// Проверяет, что значение входит в заданный диапазон.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, когда значение
        /// превыщает заданный диапазон.</exception>
        public static void AssertValueInRange(DateTime value,
                                              DateTime max, string propertyName)
        {
            if (value > max)
            {
                throw new ArgumentException(
                    $" {propertyName} должно быть в диапазоне до {max}");
            }
        }
    }
}
