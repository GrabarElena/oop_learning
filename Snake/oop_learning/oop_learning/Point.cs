using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_learning
{
    class Point
    {
        //Для того, тчобы можно было использовать эти переменные извне этого класса - тип public
        public int x;
        public int y;
        public char symb;

        //когда это быо методом - описывалось следующей конструкцией: static void draw(int x, int y, char symb)
        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symb);
        }
    }
}
