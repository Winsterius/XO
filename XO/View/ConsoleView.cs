using System;
using XO.Model;
using XO.Controllers;

namespace XO.View
{
    class ConsoleView
    {
        private Field field = new Field();
        
        public virtual void ShowField()
        {
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", field.GetFiguresArray()[0, 0], field.GetFiguresArray()[0, 1], field.GetFiguresArray()[0, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", field.GetFiguresArray()[1, 0], field.GetFiguresArray()[1, 1], field.GetFiguresArray()[1, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", field.GetFiguresArray()[2, 0], field.GetFiguresArray()[2, 1], field.GetFiguresArray()[2, 2]);
        }
    }

    class ConsoleView2 : ConsoleView
    {
        Game game = new Game();
        public override void ShowField()
        {
            Console.WriteLine("First player: {0}", Game.players[0].GetName());
            Console.WriteLine("\nSecond player: {0}\n", Game.players[1].GetName());
            base.ShowField();

        }
    }
}
