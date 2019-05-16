using System;
using XO.Model;

namespace XO.Controllers
{
    public class CurrentMoveController
    {
        static int countX = 0;
        static int countO = 0;

        public Figure CheckCurrentMove()
        {
            if (countO == countX)
            {
                countX++;
                return Figure.X;
            }
            else
            {
                countO++;
                return Figure.O;
            }
        }

    }
}
