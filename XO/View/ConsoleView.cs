using System;
using XO.Model;
using XO.Controllers;

namespace XO.View
{
    class ConsoleView
    {
        Field field = new Field();
        public void ShowField()
        {
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", field.GetFiguresArray()[0, 0], field.GetFiguresArray()[0, 1], field.GetFiguresArray()[0, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", field.GetFiguresArray()[1, 0], field.GetFiguresArray()[1, 1], field.GetFiguresArray()[1, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", field.GetFiguresArray()[2, 0], field.GetFiguresArray()[2, 1], field.GetFiguresArray()[2, 2]);
        }

    }
}
