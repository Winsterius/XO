using System;
using XO.Model;


namespace XO.Controllers
{
    public class WinnerCheckKontroller
    {

        private static Figure[,] figures;
        public static Figure winnerFigure;
        public static bool finishGame = false;


        public Figure CheckWinner(Figure[,] figs) {

            CheckHorisontals();
            CheckVerticals();
            CheckDiagonals();
            figures = figs;
            return winnerFigure;
        }
        public WinnerCheckKontroller()
        {
            figures = new Figure[3, 3];

            for (int i = 0; i < figures.GetLength(0); i++)
            {
                for (int j = 0; j < figures.GetLength(1); j++)
                    figures[i, j] = Figure._;
            }
        }

        void CheckHorisontals()
        {
            int i = 0;
            int j = 0;
            while (j  < 3)
            {             
                if (checkSameFigure(figures[i, j], figures[i + 1, j], figures[i + 2, j]))
                {
                    winnerFigure = figures[i, j];
                    finishGame = true;
                }
                j++;
            }
        }
        void CheckVerticals()
        {
            int i = 0;
            int j = 0;
            while (i < 3)
            {   
                if(checkSameFigure(figures[i, j], figures[i, j + 1], figures[i, j + 2]))                
                {
                    winnerFigure = figures[i, j];
                    finishGame = true;
                }
                i++;
            }
        }
        void CheckDiagonals()
        {
            int i = 0;
            int j = 0;
            if(checkSameFigure(figures[i, j], figures[i + 1, j + 1], figures[i + 2, j + 2]))
            {
                winnerFigure = figures[i, j];
                finishGame = true;
            }
            if(checkSameFigure(figures[i + 2, j], figures[i + 1, j + 1], figures[i + 2, j]))
            {
                winnerFigure = figures[i, j];
                finishGame = true;
            }
        }
        private bool checkSameFigure(Figure ob1, Figure ob2, Figure ob3)
        {
            if (ob1.Equals(ob2) && ob1.Equals(ob3) && !ob1.Equals(Figure._)) return true;
            else return false;
        }

    }
}