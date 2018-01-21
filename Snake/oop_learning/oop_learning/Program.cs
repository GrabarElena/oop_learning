using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_learning
{
    class Program
    {
        /// <summary>
        /// Вывести в координатах x, y значение переменной symb
        /// </summary>
        /// <param name="x">координата X</param>
        /// <param name="y">координата Y</param>
        /// <param name="symb">чего выводим</param>
        static void draw(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symb);
        }

        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 2;
            char symb1 = '*';

            draw(x1, y1, symb1);

            int x2 = 3;
            int y2 = 5;
            char symb2 = '#';

            draw(x2, y2, symb2);

            Console.ReadLine();
        }
    }
}
