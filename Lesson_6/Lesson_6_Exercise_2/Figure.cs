using System;


namespace Lesson_6_Exercise_2
{   
    public class Figure
    {
        public enum Colors { black, red, yellow, green, brown, orange, blue };
        private bool _Visibility;
        private Colors _Color;
        private int _X;
        private int _Y;

        public Colors Color => _Color;
        public bool Visibility => _Visibility;
        public int X => _X;
        public int Y => _Y;
        public Figure(Colors color, bool visibility, int x, int y)
        {
            _Color = color;
            _Visibility = visibility;
            _X = x;
            _Y = y;
        }
        public int MoveHorizontally(int dx)
        {
            return _X += dx;
        }
        public int MoveVertically(int dy)
        {
            return _Y += dy;
        }
        public Colors ChangeColor(Colors newColor)
        {
            return _Color = newColor;
        }
        public bool IsVisible()
        {
            return _Visibility;
        }
        public virtual void PrintDataOfFigure()
        {
            Console.WriteLine($"Цвет фигуры: {_Color} \r\n" +
                $"Состояние Видимости: {_Visibility} \r\n" +
                $"Координаты по горизонтали: {_X} \r\n" +
                $"Координаты по вертикали: {_Y}");
        }
    }
}
