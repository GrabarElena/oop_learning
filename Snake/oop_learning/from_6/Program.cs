using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2, '*');
            p1.draw();
            
            Point p2 = new Point(3, 5, '#');
            p2.draw();

            //в рамках стандартного класса List создали список из 4 значений
            //нумерация с 0
            List<int> numlist = new List<int>();
            numlist.Add(0);
            numlist.Add(1);
            numlist.Add(2);
            numlist.Add(3);

            //доступ к элементам списка List
            int x = numlist[0];
            int y = numlist[2];
            int z = numlist[3];

            //прочитать все элементы списка и вывести их на консоль
            foreach (int i in numlist)
            {
                Console.WriteLine(i);
            }

            //удаление элементов списка
            numlist.RemoveAt(0);

            //список точек
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Console.ReadLine();
        }
    }
}
