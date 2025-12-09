namespace Lab6.Cats
{
    /// <summary>
    /// Декоратор для подсчёта количества вызовов Meow() у IMeowable.
    /// </summary>
    public class CatMeowCounter : IMeowable
    {
        private readonly IMeowable _inner;
        private int _counter;

        /// <summary>
        /// Количество зарегистрированных мяуканий.
        /// </summary>
        public int Counter => _counter;

        /// <summary>
        /// Создаёт декоратор вокруг <paramref name="inner"/>.
        /// </summary>
        /// <param name="inner">Объект, чьи мяуканья нужно считать.</param>
        public CatMeowCounter(IMeowable inner)
        {
            _inner = inner ?? throw new System.ArgumentNullException(nameof(inner));
        }

        /// <summary>
        /// Вызывает Meow() у вложенного объекта и увеличивает счётчик.
        /// </summary>
        public void Meow()
        {
            _counter++;
            _inner.Meow();
        }
    }
}
