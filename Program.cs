using System;

namespace ReferenceTypes
{
    //Класс "Программа"
    class Program
    {
        static void Main(string[] args)
        {
            //Задание параметров классу 
            Figure line = new Line(0, 1, 2, 3);
            //Вызов метода 
            line.Draw();
            Figure circle = new Circle(5, 0, 0);
            circle.Draw();
            Figure rectangle = new Rectangle(1, 1, 10, 10);
            rectangle.Draw();
            Figure round = new Round(4, 4, 10, "purple");
            round.Draw();
            Figure ring = new Ring(4, 4, 10, 15, "purple");
            ring.Draw();
        }
    }
}
