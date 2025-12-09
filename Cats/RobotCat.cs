using System;

namespace Lab6.Cats
{
    /// <summary>
    /// Роботизированный кот для демонстрации интерфейса IMeowable.
    /// </summary>
    public class RobotCat : IMeowable
    {
        /// <summary>
        /// Имя робота-кота.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Создаёт нового робота-кота.
        /// </summary>
        /// <param name="name">Имя робота.</param>
        public RobotCat(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                Name = "Robot";
            else
                Name = name;
        }

        /// <summary>
        /// Выполняет мяуканье робота-кота.
        /// </summary>
        public void Meow()
        {
            Console.WriteLine($"{Name}: бип-бип-мяу!");
        }

        /// <summary>
        /// Строковое представление робота-кота.
        /// </summary>
        public override string ToString() => $"робот-<кот>: {Name}";
    }
}
