using System;

namespace Lab6.Utils
{
    /// <summary>
    /// Вспомогательные проверки входных данных.
    /// </summary>
    public static class Guard
    {
        /// <summary>
        /// Проверяет, что значение не равно null.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="paramName">Имя параметра.</param>
        public static void ArgumentNotNull(object value, string paramName)
        {
            if (value == null)
                throw new ArgumentNullException(paramName);
        }

        /// <summary>
        /// Проверяет, что строка не пустая и не только пробелы.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="param name">Имя параметра.</param>
        public static void ArgumentNotNullOrWhiteSpace(string value, string paramName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"Параметр '{paramName}' не может быть пустым или состоять только из пробелов", paramName);
        }

        /// <summary>
        /// Проверяет, что значение находится в диапазоне [min, max].
        /// </summary>
        public static void ArgumentInRange(int value, int min, int max, string paramName)
        {
            if (value < min || value > max)
                throw new ArgumentOutOfRangeException(paramName, $"Значение должно быть между {min} и {max}");
        }
    }
}
