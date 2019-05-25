using System;
using XO.View;

namespace XO.Model
{
    class CreateTheGame
    {
        private bool finishGame = false;
        ConsoleView cv = new ConsoleView();
        ConsoleView2 cv2 = new ConsoleView2();
        Game game;
        AI ai;
        public static Player p1, p2;

        public void Menu()
        {
            int userInput;
            cv.ShowMenu();
            while (!int.TryParse(Console.ReadLine(), out userInput)) Console.WriteLine("wrong input");
            while (!finishGame)
            {
                switch (userInput)
                {
                    case 1:
                        cv2.askingForPlayers("second");
                        game = new Game(p1, p2);
                        Field field = new Field(3);
                        game.Start();
                        cv.showWinner();
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                        break;
                    case 2:
                        cv = new ConsoleViewOnePlayer();
                        cv.askingForPlayers("first");
                        game = new GameOnePlayer(p1);
                        field = new Field(3);
                        cv.AskingForFigure();
                        ai = new AI(ConsoleView.figurePlayerInput);
                        game.Start();
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                        break;
                    case 3:
                        finishGame = true;
                        break;
                }
            }
        }
    }
}
