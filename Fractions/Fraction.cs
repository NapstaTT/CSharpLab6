using System;

namespace Lab6.Fractions
{
    /// <summary>
    /// Класс, представляющий дробь с целыми числителем и знаменателем.
    /// </summary>
    public class Fraction : IFraction, ICloneable
    {
        private int _numerator;
        private int _denominator;

        /// <summary>
        /// Создаёт дробь с заданными числителем и знаменателем.
        /// </summary>
        /// <param name="numerator">Числитель.</param>
        /// <param name="denominator">Знаменатель (не 0).</param>
        /// <exception cref="ArgumentException">Если denominator == 0.</exception>
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен нулю", nameof(denominator));

            _numerator = numerator;
            _denominator = denominator;
            NormalizeSign();
        }

        /// <summary>
        /// Числитель дроби.
        /// </summary>
        public virtual int Numerator
        {
            get => _numerator;
            set
            {
                _numerator = value;
                NormalizeSign();
            }
        }

        /// <summary>
        /// Знаменатель дроби.
        /// </summary>
        public virtual int Denominator
        {
            get => _denominator;
            set
            {
                if (value == 0)
                    throw new ArgumentException("Знаменатель не может быть равен нулю", nameof(value));

                _denominator = value;
                NormalizeSign();
            }
        }

        private void NormalizeSign()
        {
            if (_denominator < 0)
            {
                _numerator = -_numerator;
                _denominator = -_denominator;
            }
        }

        /// <summary>
        /// Возвращает вещественное значение дроби (числитель / знаменатель).
        /// </summary>
        public virtual double GetRealValue() => (double)_numerator / _denominator;

        /// <summary>
        /// Сложение двух дробей.
        /// </summary>
        public static Fraction operator +(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        /// <summary>
        /// Вычитание двух дробей.
        /// </summary>
        public static Fraction operator -(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        /// <summary>
        /// Умножение двух дробей.
        /// </summary>
        public static Fraction operator *(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Numerator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        /// <summary>
        /// Деление двух дробей.
        /// </summary>
        /// <exception cref="DivideByZeroException">Если делитель равен нулю.</exception>
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Numerator == 0)
                throw new DivideByZeroException("Деление на ноль");

            int newNumerator = a.Numerator * b.Denominator;
            int newDenominator = a.Denominator * b.Numerator;
            return new Fraction(newNumerator, newDenominator);
        }

        // Операции с int
        public static Fraction operator +(Fraction a, int b) => a + new Fraction(b, 1);
        public static Fraction operator +(int a, Fraction b) => new Fraction(a, 1) + b;
        public static Fraction operator -(Fraction a, int b) => a - new Fraction(b, 1);
        public static Fraction operator *(Fraction a, int b) => a * new Fraction(b, 1);
        public static Fraction operator *(int a, Fraction b) => new Fraction(a, 1) * b;
        public static Fraction operator /(Fraction a, int b) => a / new Fraction(b, 1);

        /// <summary>
        /// Сравнение дробей по полям числитель/знаменатель.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Fraction other)
            {
                return Numerator == other.Numerator && Denominator == other.Denominator;
            }
            return false;
        }

        /// <summary>
        /// Хэш-код дроби, основанный на числителе и знаменателе.
        /// </summary>
        public override int GetHashCode() => HashCode.Combine(Numerator, Denominator);

        /// <summary>
        /// Создаёт поверхностную копию дроби.
        /// </summary>
        public object Clone() => new Fraction(Numerator, Denominator);

        /// <summary>
        /// Возвращает строковое представление дроби в формате "числитель/знаменатель".
        /// </summary>
        public override string ToString() => $"{Numerator}/{Denominator}";
    }
}
