using System;


namespace Lesson_6_Exercise_2
{
    class Circle : Point
    {
        private double _Radius;
        public double Radius => _Radius;
        public Circle (Colors color, bool visibility, int x, int y, double radius) : base (color, visibility, x, y)
        {
            _Radius = radius;
        }
        public double CirclesArea (double radius)
        {
            return 3.14 * radius * radius;
        }
        public override void PrintDataOfFigure()
        {
            base.PrintDataOfFigure();
            Console.WriteLine($"Радиус круга: {_Radius} \r\n" +
                $"Площадь круга: {CirclesArea(_Radius)}");
        }
    }
}
