Отчёт по лабораторной работе №6 — Интерфейсы и шаблоны ООП
Студент: Гилев Артем
Группа: ИТ-10
1. Цель работы
  Изучить интерфейсы, перегрузку операторов, шаблоны декоратора и кэширующего прокси; реализовать сущности "Кот" и "Дробь".
2. Структура проекта:
  2.1 Cats/Cat.cs
  2.2 Cats/CatMeowCounter.cs
  2.3 Cats/Funs.cs
  2.4 Cats/IMeowable.cs
  2.5 Cats/RobotCat.cs
  2.6 Fractions/CachedFraction.cs
  2.7 Fractions/Fraction.cs
  2.8 Fractions/IFraction.cs
  2.9 Lab6.csproj
  2.10 Program.cs
  2.11 Utils/Guard.cs
3. Краткое описание файлов
  Cats/: реализация IMeowable, Cat, RobotCat, декоратор CatMeowCounter и вспомогательные функции Funs.
  Fractions/: интерфейс IFraction, классы Fraction и CachedFraction с перегрузками операторов.
  Utils/: Guard — проверки аргументов.
4. Инструкция по сборке и генерации XML-документации
  1) Открыть терминал в папке проекта (где Lab6.csproj).
  2) Выполнить: dotnet build
  3) После сборки в bin/Debug/net8.0 появится файл Documentation.xml, содержащий сгенерированную документацию из /// комментариев.
5. Пример вывода программы
<img width="416" height="836" alt="image" src="https://github.com/user-attachments/assets/9069958e-388f-4cc1-8aa5-ecf6ac538994" />
