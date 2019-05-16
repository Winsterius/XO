using System;
using XO.Model;

namespace XO.Controllers
{
    public class CurrentMoveController
    {
        static int countX = 0;
        static int countO = 0;
        
        Game game = new Game();
        public Figure CheckCurrentMove()
        {
            if (countO == countX)
            {
                Console.WriteLine("{0}, it is your turn", game.GetNamePlayer(Figure.X));
                countX++;
                return Figure.X;
            }
            else
            {
                Console.WriteLine("{0}, it is your turn", game.GetNamePlayer(Figure.O));
                countO++;
                return Figure.O;
            }
        }

    }
}
