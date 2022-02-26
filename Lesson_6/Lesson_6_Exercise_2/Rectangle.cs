using System;


namespace Lesson_6_Exercise_2
{
    class Rectangle : Point
    {
        private double _Lengh;
        private double _Width;
        public double Lengh => _Lengh;
        public double Width => _Width;
        public Rectangle (Colors color, bool visibility, int x, int y, double lengh, double width) : base (color, visibility, x, y)
        {
            _Lengh = lengh;
            _Width = width;
        }
        public double RectanglesArea (double lengh, double width)
        {
            return lengh * width;
        }
        public override void PrintDataOfFigure()
        {
            base.PrintDataOfFigure();
            Console.WriteLine($"Длина прямоугольника: {_Lengh} \r\n" +
                $"Ширина прямоугольника: {_Width} \r\n" +
                $"Площадь прямоугольника: {RectanglesArea(_Lengh, _Width)}");
        }
    }
}
