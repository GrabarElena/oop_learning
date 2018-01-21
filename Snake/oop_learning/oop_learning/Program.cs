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
        
        //ушло в Point
        //static void draw(int x, int y, char symb)
        //{
        //    Console.SetCursorPosition(x, y);
        //    Console.WriteLine(symb);
        //}

        static void Main(string[] args)
        {

            //ушло в класс Point
            //int x1 = 1;
            //int y1 = 2;
            //char symb1 = '*';
            //draw(x1, y1, symb1);
            /* убрали в конструктор внутри класса Point
            p1.x = 1;
            p1.y = 2;
            p1.symb = '*';
            */
            //draw(p1.x, p1.y, p1.symb); - метод, описываемый в текущем проекте. При уходе в класс не актуально
            Point p1 = new Point(1, 2, '*');
            p1.draw();


            //int x2 = 3;
            //int y2 = 5;
            //char symb2 = '#';
            //draw(x2, y2, symb2);
            /* убрали в конструктор внутри класса Point
            p2.x = 3;
            p2.y = 5;
            p2.symb = '#';*/
            //draw(p2.x, p2.y, p2.symb);- метод, описываемый в текущем проекте. При уходе в класс не актуально
            Point p2 = new Point(3, 5, '#');
            p2.draw();

            Console.ReadLine();
        }
    }
}
