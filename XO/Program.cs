using System;
using XO.View;
using XO.Model;
using XO.Controllers;


namespace XO
{
    class Program
    {
        public static Player p1, p2;

        static void Main(string[] args)
        {
            ConsoleView cv = new ConsoleView();
            ConsoleView2 cv2 = new ConsoleView2();

            cv2.askingForPlayers();

            Game game = new Game(p1, p2);
            Field field = new Field(3);


            game.Start();
           
            cv.ShowField();
            cv.showWinner();
            Console.ReadKey();

        }        
    }
}
