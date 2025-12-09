using System.Collections.Generic;

namespace Lab6.Cats
{
    /// <summary>
    /// Вспомогательные методы для работы с IMeowable-объектами.
    /// </summary>
    public static class Funs
    {
        /// <summary>
        /// Заставляет все объекты коллекции мяукнуть.
        /// </summary>
        /// <param name="meowables">Коллекция мяукающих объектов.</param>
        public static void MeowAll(IEnumerable<IMeowable> meowables)
        {
            foreach (var m in meowables)
                m.Meow();
        }

        /// <summary>
        /// Вызывает Meow() 5 раз у переданного объекта.
        /// </summary>
        /// <param name="meowable">Объект, который будет заботиться.</param>
        public static void MeowsCare(IMeowable meowable)
        {
            for (int i = 0; i < 5; i++)
                meowable.Meow();
        }
    }
}
