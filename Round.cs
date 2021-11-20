using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceTypes
{
    //Класс Round
    public class Round : Figure
    {
        //Конструктор Round
        public Round(int x, int y, int r, string colourfill) : base (x, y)
        {
            R = r;
            ColourFill = colourfill;
        }
        public int R { get; set; }
        public string ColourFill { get; set; }
        //Использование метода Draw
        public override void Draw()
        {
            Console.WriteLine("Круг. Координаты центра круга: х = {0}, у = {1}. Радиус равен {2}. Цвет заливки фигуры - {3}", X, Y, R, ColourFill);
        }
    }
}
