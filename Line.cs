using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceTypes
{
    //Класс Line
    public class Line : Figure
    {
        //Конструктор Line
        public Line(int x1, int x2, int y1, int y2) : base (x1, y1)
        {
            EndX = x2;
            EndY = y2;
        }
        public int EndX { get; set; }
        public int EndY { get; set; }
        //Использование метода Draw
        public override void Draw()
        {
            Console.WriteLine("Линия. Координаты фигуры: х1 = {0}, x2 = {1}, y1 = {2}, y2 = {3}", X, EndX, Y, EndY);
        }
    }
}
