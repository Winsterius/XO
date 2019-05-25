using System;
using XO.Controllers;
using XO.View;

namespace XO.Model
{
    public class Game
    {
        protected int count;
        public static Player[] players;


        ConsoleView cv = new ConsoleView();
        ConsoleView2 cv2 = new ConsoleView2();
        protected MoveController mc = new MoveController();

        protected CurrentMoveController cmc = new CurrentMoveController();
        protected Field field = new Field();
        protected WinnerCheckKontroller wc = new WinnerCheckKontroller();

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
            while (!WinnerCheckKontroller.finishGame)
            {
                cv2.ShowField();
                mc.AskForMove(cmc.CheckCurrentMove(field.GetFiguresArray()));
                wc.CheckWinner(field.GetFiguresArray());
                Console.Clear();
                count++;
                if (count == 9 && !WinnerCheckKontroller.finishGame)
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
            ConsoleViewOnePlayer cv2 = new ConsoleViewOnePlayer();
            CurrentMoveController cmc = new CurrentMoveControllerOnePlayer();
            MoveController mc = new MoveControllerOnePlayer();
            Field field = new Field();
            WinnerCheckKontroller wc = new WinnerCheckKontroller();
            while (!WinnerCheckKontroller.finishGame)
            {
                cv2.ShowField();
                mc.AskForMove(cmc.CheckCurrentMove(field.GetFiguresArray()));
                wc.CheckWinner(field.GetFiguresArray());
                Console.Clear();
                count++;
                if (count == 9 && !WinnerCheckKontroller.finishGame)
                {
                    Console.WriteLine("Nobody wins");
                    Console.ReadKey();
                    return;
                }
            }
        }
        public override string GetNamePlayer(Figure figure)
        {
            return " "; 
        }
    }
}
