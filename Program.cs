using System;
using System.Collections.Generic;
using Lab6.Cats;
using Lab6.Fractions;

namespace Lab6
{
    /// <summary>
    /// Демонстрация работы лабораторной работы №6.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа. Делает демонстрацию работы котов и дробей.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("=== ЗАДАНИЕ 1: КОТЫ ===\n");

            var barsik = new Cat("Барсик");
            Console.WriteLine($"Создан: {barsik}");
            Console.Write("Мяуканье один раз: ");
            barsik.Meow();
            Console.Write("Мяуканье три раза: ");
            barsik.Meow(3);

            Console.WriteLine("\n--- Метод для всех мяукающих ---");

            var murzik = new Cat("Мурзик");
            var pushok = new Cat("Пушок");

            var meowables = new List<IMeowable> { barsik, murzik, pushok };
            var robot = new RobotCat("R2-D2");
            meowables.Add(robot);

            Console.WriteLine("Все мяукают:");
            Funs.MeowAll(meowables);

            Console.WriteLine("\n--- Подсчет мяуканий ---");
            var counter = new CatMeowCounter(barsik); // декорируем конкретного кота
            Funs.MeowsCare(counter);
            Console.WriteLine($"Кот мяукал {counter.Counter} раз");

            Console.WriteLine("\n=== ЗАДАНИЕ 2: ДРОБИ ===\n");

            var f1 = new Fraction(1, 3);
            var f2 = new Fraction(2, 3);
            var f3 = new Fraction(3, 4);

            Console.WriteLine($"f1 = {f1}");
            Console.WriteLine($"f2 = {f2}");
            Console.WriteLine($"f3 = {f3}");

            Console.WriteLine($"\n{f1} + {f2} = {f1 + f2}");
            Console.WriteLine($"{f1} - {f2} = {f1 - f2}");
            Console.WriteLine($"{f1} * {f2} = {f1 * f2}");
            Console.WriteLine($"{f1} / {f2} = {f1 / f2}");
            Console.WriteLine($"{f1} + 2 = {f1 + 2}");
            Console.WriteLine($"{f1} * 3 = {f1 * 3}");

            var result = (f1 + f2) / f3 - 5;
            Console.WriteLine($"\n({f1} + {f2}) / {f3} - 5 = {result}");

            Console.WriteLine("\n--- Сравнение дробей ---");
            var f4 = new Fraction(2, 4);
            var f5 = new Fraction(1, 2);
            var f6 = new Fraction(2, 4);

            Console.WriteLine($"{f4} == {f5} ? {f4.Equals(f5)}");
            Console.WriteLine($"{f4} == {f6} ? {f4.Equals(f6)}");

            Console.WriteLine("\n--- Клонирование дроби ---");
            var original = new Fraction(3, 5);
            var clone = (Fraction)original.Clone();
            Console.WriteLine($"Оригинал: {original}");
            Console.WriteLine($"Клон: {clone}");
            Console.WriteLine($"Равны? {original.Equals(clone)}");

            Console.WriteLine("\n--- Кэшированная дробь ---");
            var cached = new CachedFraction(1, 3);
            Console.WriteLine($"Первое вычисление: {cached.GetRealValue()}"); 
            Console.WriteLine($"Второе вычисление (из кэша): {cached.GetRealValue()}"); 

            cached.Numerator = 2;
            Console.WriteLine($"После изменения числителя: {cached.GetRealValue()}"); 
            Console.WriteLine($"Следующее вычисление (из кэша): {cached.GetRealValue()}"); 

            Console.WriteLine("\n=== ВСЕ ЗАДАНИЯ ВЫПОЛНЕНЫ ===");
        }
    }
}
