namespace Lab6.Fractions
{
    /// <summary>
    /// Интерфейс для дробей.
    /// </summary>
    public interface IFraction
    {
        /// <summary>
        /// Числитель дроби.
        /// </summary>
        int Numerator { get; set; }

        /// <summary>
        /// Знаменатель дроби (не может быть равен 0).
        /// </summary>
        int Denominator { get; set; }

        /// <summary>
        /// Возвращает вещественное значение дроби.
        /// </summary>
        double GetRealValue();
    }
}
