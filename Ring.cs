using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceTypes
{
    //Класс Ring
    public class Ring : Figure
    {
        //Конструктор Ring
        public Ring(int x, int y, int r1, int r2, string colourfill) : base(x, y)
        {
            R1 = r1;
            R2 = r2;
            ColourFill = colourfill;
        }

        public int R1 { get; set; }
        public int R2 { get; set; }
        public string ColourFill { get; set; }
        //Использование метода Draw
        public override void Draw()
        {
            Console.WriteLine("Кольцо. Координаты центра: х = {0}, у = {1}; радиус 1 окружности равен {2}; радиус 2 окружности равен {3}. Цвет заливки фигуры - {4}", X, Y, R1, R2, ColourFill);
        }
    }
}
