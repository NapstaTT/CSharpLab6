namespace Lab6.Fractions
{
    /// <summary>
    /// Дробь с кэшированием вещественного значения.
    /// </summary>
    public class CachedFraction : Fraction
    {
        private double? _cachedValue;

        /// <summary>
        /// Создаёт кэшированную дробь.
        /// </summary>
        public CachedFraction(int numerator, int denominator) : base(numerator, denominator) { }

        /// <summary>
        /// При изменении числителя сбрасываем кэш.
        /// </summary>
        public new int Numerator
        {
            get => base.Numerator;
            set
            {
                base.Numerator = value;
                _cachedValue = null;
            }
        }

        /// <summary>
        /// При изменении знаменателя сбрасываем кэш.
        /// </summary>
        public new int Denominator
        {
            get => base.Denominator;
            set
            {
                base.Denominator = value;
                _cachedValue = null;
            }
        }

        /// <summary>
        /// Возвращает вещественное значение с кэшированием.
        /// </summary>
        public override double GetRealValue()
        {
            if (_cachedValue == null)
                _cachedValue = base.GetRealValue();
            return _cachedValue.Value;
        }
    }
}
