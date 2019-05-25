using System;
using XO.Model;
using XO.Controllers;

namespace XO.View
{
    class ConsoleView
    {
        public static string figurePlayerInput;
        private bool finish;
        readonly Field field = new Field();
        Game game;

        public virtual void ShowField()
        {
            game = new Game();
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", field.GetFiguresArray()[0, 0], field.GetFiguresArray()[0, 1], field.GetFiguresArray()[0, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", field.GetFiguresArray()[1, 0], field.GetFiguresArray()[1, 1], field.GetFiguresArray()[1, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", field.GetFiguresArray()[2, 0], field.GetFiguresArray()[2, 1], field.GetFiguresArray()[2, 2]);

        }
        public virtual void askingForPlayers(string str)
        {
            Console.WriteLine("Please enter the name of {0} player", str);
            CreateTheGame.p1 = new Player(Figure._, Console.ReadLine());

        }
        public void AskingForFigure()
        {
            while (!finish) 
            {
                Console.WriteLine("Please insert the figure you want play");
                figurePlayerInput = Console.ReadLine().ToUpper();
                if ("X".Equals(figurePlayerInput) || "O".Equals(figurePlayerInput)) finish = true;
            }
        }
        public void showWinner(){
            game = new Game();
            Console.WriteLine("The winner is {0}", game.GetNamePlayer(WinnerCheckKontroller.winnerFigure));
        }
        public void ShowMenu()
        {
            Console.WriteLine("1:   Player vs player");
            Console.WriteLine("2:   Player vs computer");
            Console.WriteLine("3:   Exit the game");
        }
    }
    class ConsoleView2 : ConsoleView
    {
        public override void askingForPlayers(string str)
        {

            base.askingForPlayers("first");
            Console.WriteLine("Please enter the name of {0} player", str);
            CreateTheGame.p2 = new Player(Figure.O, Console.ReadLine());
            Console.Clear();
        }
        public override void ShowField()
        {
            Console.WriteLine("First player: {0}", Game.players[0].GetName());
            base.ShowField();
        }       
    }
    class ConsoleViewOnePlayer : ConsoleView
    {
        Player player = new Player();
        public override void ShowField()
        {
            Console.WriteLine("First player: {0}", Game.players[0].GetName());
            base.ShowField();
        }
        public override void askingForPlayers(string str)
        {
            base.askingForPlayers(str);
        }
    }
}
    
