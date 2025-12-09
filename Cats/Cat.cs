using System;

namespace Lab6.Cats
{
    /// <summary>
    /// Представляет кота, который умеет мяукать.
    /// </summary>
    public class Cat : IMeowable
    {
        /// <summary>
        /// Имя кота.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Создаёт нового кота.
        /// </summary>
        /// <param name="name">Имя кота.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если имя пустое.</exception>
        public Cat(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Имя кота не может быть пустым", nameof(name));

            Name = name;
        }

        /// <summary>
        /// Кот мяукает один раз.
        /// </summary>
        public void Meow()
        {
            Console.WriteLine($"{Name}: мяу!");
        }

        /// <summary>
        /// Кот мяукает несколько раз.
        /// </summary>
        /// <param name="n">Количество мяуканий.</param>
        /// <exception cref="ArgumentException">Если n ≤ 0.</exception>
        public void Meow(int n)
        {
            if (n <= 0)
                throw new ArgumentException("Количество мяуканий должно быть положительным", nameof(n));

            Console.Write($"{Name}: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write("мяу");
                if (i < n - 1)
                    Console.Write("-");
            }

            Console.WriteLine("!");
        }

        /// <summary>
        /// Возвращает строковое представление кота.
        /// </summary>
        public override string ToString() => $"кот: {Name}";
    }
}
