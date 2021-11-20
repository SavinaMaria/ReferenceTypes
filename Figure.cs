using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceTypes
{
    //Абстрактный класс Figure
    public abstract class Figure
    {
        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int Y { get; set; }
        public int X { get; set; }
        //Объявление абстрактного метода Draw
        public abstract void Draw();
    }
}
