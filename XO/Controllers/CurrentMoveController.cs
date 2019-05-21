using System;
using XO.Model;

namespace XO.Controllers
{
    public class CurrentMoveController
    {
        
        Game game = new Game();

        private void print(string str) { Console.WriteLine("{0}, it is your turn", str); }

        public Figure CheckCurrentMove(Figure[,] figs)
        {
            int countX = 0;
            int countO = 0;

            foreach (Figure fig in figs)
            {
                if (fig.Equals(Figure.O)) countO++;
                if (fig.Equals(Figure.X)) countX++;
            }
            if (countX == countO)
            {
                print(game.GetNamePlayer(Figure.X));
                return Figure.X;
            }
            else
            {
                print(game.GetNamePlayer(Figure.O));
                return Figure.O;
            }
        }
    }
}
