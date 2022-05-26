using System;

namespace Programming.Model.Classes
{
    public static class Validator
    {

        public static void AssertOnPositiveValue(string property, int value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Значение поля {property} должно быть положительным");
            }
        }

        public static void AssertOnPositiveValue(string property, double value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Значение поля {property} должно быть положительным");
            }
        }

        public static void AssertValueInRange(int value, int min, int max, string fieldName)
        {
            if ((value > max || value < min))
            {
                throw new ArgumentException($"Введите корректное значение от 0 до 60 {fieldName}");
            }
        }

        public static void AssertValueInRange(double value, double min, double max, string fieldName)
        {
            if ((value > max || value <  min))
            {
                throw new ArgumentException($"Введите корректное значение от 0 до 60 {fieldName}");
            }
        }

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
