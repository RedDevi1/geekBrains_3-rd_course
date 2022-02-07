using System;

namespace Lesson_6_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new(Figure.Colors.black, true, 3, 3);
            point.PrintDataOfFigure();
            Circle circle = new(Figure.Colors.red, true, 1, 2, 7);
            Rectangle rectangle = new(Figure.Colors.green, false, 3, 4, 7, 9);

            Console.WriteLine();
            Console.WriteLine("До изменений состояние полей круга:");
            circle.PrintDataOfFigure();

            Console.WriteLine();
            Console.WriteLine("До изменений состояние полей прямоугольника:");
            rectangle.PrintDataOfFigure();
            Console.WriteLine();

            circle.MoveHorizontally(4);
            circle.IsVisible();
            rectangle.MoveVertically(4);
            rectangle.ChangeColor(Figure.Colors.blue);

            Console.WriteLine("После изменений состояние полей круга:");
            circle.PrintDataOfFigure();
            Console.WriteLine();

            Console.WriteLine("После изменений состояние полей прямоугольника:");
            rectangle.PrintDataOfFigure();

        }
    }
}
