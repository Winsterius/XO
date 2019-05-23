using System;
using XO.Controllers;
using XO.View;

namespace XO.Model
{
    public class Game
    {
        private int count;
        public static Player[] players;


        readonly ConsoleView cv = new ConsoleView();
        readonly ConsoleView2 cv2 = new ConsoleView2();
        readonly MoveController mc = new MoveController();

        readonly CurrentMoveController cmc = new CurrentMoveController();
        readonly Field field = new Field();
        readonly WinnerCheckKontroller wc = new WinnerCheckKontroller();

        public Game() { }
        public Game(Player player) { players = new Player[] { player }; }
        public Game(Player player1, Player player2)
        {
            players = new Player[] { player1, player2 };

        }
        public virtual string GetNamePlayer(Figure figure)
        {              
            if (figure.Equals(Figure.X)) return players[0].GetName();
            if (figure.Equals(Figure.O)) return players[1].GetName();
            else return "I am this idiot who had written this code";
        }

        public virtual void Start()
        {
            ConsoleViewOnePlayer cvop = new ConsoleViewOnePlayer();
            while (!WinnerCheckKontroller.finishGame)
            {
                cvop.ShowField();
                mc.AskForMove(cmc.CheckCurrentMove(field.GetFiguresArray()));
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
    public class GameOnePlayer : Game
    {
        
        public GameOnePlayer(Player p1) { Game game = new Game(p1); }
        public GameOnePlayer() { }

        public override void Start()
        {
            base.Start();
        }
        public override string GetNamePlayer(Figure figure)
        {
            return " "; 
        }
    }
}
