using System;
using System.Text.RegularExpressions;

namespace ContactList.Model
{
    public static class Validator
    {
        public static void AssertEmptyValue(string value, string propertyName)
        {
            if (value == "")
            {
                throw new ArgumentException($"Строка не может быть пустой в поле {propertyName}");
            }
        }
        public static void AssertLengthString(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"Строка превышает максимальную длину: " +
                                            $"{maxLength} в поле {propertyName}.");
            }
        }

        public static void IsUrlLink(string value, string propertyName)
        {
            if (!Regex.IsMatch(value, @"(https?:\/\/)?(www\.)?(vk.com\/)(id\d|[a-zA-z][a-zA-Z0-9_.]{2,})"))
            {
                throw new ArgumentException($"Должна быть ссылка на {propertyName}.");
            }
        }

        public static void IsPhoneNumber(string value, string propertyName)
        {
            if (!Regex.IsMatch(value, @"^(\+7[0-9]{9}[0-9]$)"))
            {
                throw new ArgumentException(
                    $" { propertyName} начинается с '+' и дальше идут 11 цифр.");
            }
        }

        public static void AssertValueInRange(int value, int max, string propertyName)
        {
            if (value > max)
            {
                throw new ArgumentException(
                    $" {propertyName} должно находиться в диапозоне до {max}");
            }
        }

        public static void AssertValueInRange(DateTime value, DateTime max, string propertyName)
        {
            if (value > max)
            {
                throw new ArgumentException(
                    $" {propertyName} должно быть в диапазоне до {max}");
            }
        }
    }
}
