using System;
using XO.View;
using XO.Model;
using XO.Controllers;


namespace XO
{
    class Program
    {
        static Player p1;
        static Player p2;
        static int count;

        static void Main(string[] args)
        {

            askingForPlayers();

            Game game = new Game(p1, p2);
            Field field = new Field(3);
            MoveController mc = new MoveController();
            CurrentMoveController cmc = new CurrentMoveController();
            WinnerCheckKontroller wc = new WinnerCheckKontroller();
            ConsoleView cv = new ConsoleView();
            ConsoleView2 cv2 = new ConsoleView2();
            Start();
           
            cv.ShowField();
            Console.WriteLine("The winner is {0}", game.GetNamePlayer(WinnerCheckKontroller.winnerFigure));
            Console.ReadKey();

            void Start()
            {
                while (!WinnerCheckKontroller.finishGame)
                {
                    cv2.ShowField();
                    mc.AskForMove2(cmc.CheckCurrentMove(field.GetFiguresArray()));
                    wc.CheckWinner(field.GetFiguresArray());
                    Console.Clear();
                    count++;
                    if (count == 9)
                    {
                        Console.WriteLine("Nobody wins");
                        Console.ReadKey();
                        return;
                    }
                }
            }

        }
        static void askingForPlayers()
        {
            Console.WriteLine("Please enter the name of first player");
            p1 = new Player(Figure.X, Console.ReadLine());
            Console.WriteLine("Please enter the name of second player");
            p2 = new Player(Figure.O, Console.ReadLine());
            Console.Clear();
        }
        
    }
}
