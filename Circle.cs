using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceTypes
{
    //Класс Circle
    public class Circle : Figure
    {
        //Конструктор Circle
        public Circle(int r, int x1, int y1) : base (x1, y1)
        {
            R = r;
        }
        public int R { get; set; }
        //Использование метода Draw
        public override void Draw()
        {
            Console.WriteLine("Окружность. Координаты центра окружности: х = {0}, у = {1}. Радиус равен {2}", X, Y, R);
        }
    }
}
