using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_learning
{
    class Point
    {
        //Для того, чтобы можно было использовать эти переменные извне этого класса - тип public
        public int x;
        public int y;
        public char symb;

        //Конструктор внутри класса. Данный конструктор присваивает значения в скобках программы переменным выше в классе
        public Point(int _x, int _y, char _symb)
        {
            x = _x;
            y = _y;
            symb = _symb;
        }

        //когда это быо методом - описывалось следующей конструкцией: static void draw(int x, int y, char symb)
        // тут переменные объявлены выше и дополнительно их почему-то не надо указывать
        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symb);
        }
    }
}
