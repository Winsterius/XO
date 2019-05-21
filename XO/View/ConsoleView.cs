using System;
using XO.Model;
using XO.Controllers;

namespace XO.View
{
    class ConsoleView
    {
        readonly Field field = new Field();
        private Game game;
        public virtual void ShowField()
        {
            game = new Game();
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", field.GetFiguresArray()[0, 0], field.GetFiguresArray()[0, 1], field.GetFiguresArray()[0, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", field.GetFiguresArray()[1, 0], field.GetFiguresArray()[1, 1], field.GetFiguresArray()[1, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", field.GetFiguresArray()[2, 0], field.GetFiguresArray()[2, 1], field.GetFiguresArray()[2, 2]);

        }
        public void askingForPlayers()
        {
            Console.WriteLine("Please enter the name of first player");
            Program.p1 = new Player(Figure.X, Console.ReadLine());
            Console.WriteLine("Please enter the name of second player");
            Program.p2 = new Player(Figure.O, Console.ReadLine());
            Console.Clear();
        }
        public void showWinner(){
            Console.WriteLine("The winner is {0}", game.GetNamePlayer(WinnerCheckKontroller.winnerFigure));
        }

    }
    class ConsoleView2 : ConsoleView
    {

        public override void ShowField()
        {
            Console.WriteLine("First player: {0}", Game.players[0].GetName());
            Console.WriteLine("\nSecond player: {0}\n", Game.players[1].GetName());
            base.ShowField();
        }       
    }
}
    
