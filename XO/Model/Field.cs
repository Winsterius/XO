using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.Model
{
    public class Field
    {
        private const int MIN_COORDINATE = 0;
        private static int MAX_COORDINATE;

        private static Figure[,] figures;
        
        public void setFigureOnField(Figure figure, int x, int y)
        {
            figures[x, y] = figure;

        }

        

        public int getArrLength() => figures.GetLength(0);
        public Figure[,] GetFigures() => figures; 

        public Figure[,] GetFiguresArray() { return figures; }
        public Field() { }
        public Field(int x)
        {
            MAX_COORDINATE = x;
            figures = new Figure[MAX_COORDINATE, MAX_COORDINATE];

            for (int i = 0; i < figures.GetLength(0); i++)
            {
                for (int j = 0; j < figures.GetLength(1); j++)
                    figures[i, j] = Figure._;
            }
        }
    }
}
