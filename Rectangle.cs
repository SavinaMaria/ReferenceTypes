using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceTypes
{
    //Класс Rectangle
    public class Rectangle : Figure
    {
        //Конструктор Rectangle
        public Rectangle(int x1, int y1, int x2, int y2) : base (x1, y1)
        {
            x2 = EndX;
            y2 = EndY;
        }
        public int EndX { get; set; }
        public int EndY { get; set; }
        //Использование метода Draw
        public override void Draw()
        {
            Console.WriteLine("Прямоугольник. Координаты 1 точки фигуры: х = {0}, у = {1}; координаты 2 точки фигуры х = {2}, у = {3}", X, Y, EndX, EndY);
        }
    }
}
