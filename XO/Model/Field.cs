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
        private static int MAX_COORDINATE = 3;

        private Figure[,] figures = new Figure[MAX_COORDINATE, MAX_COORDINATE]; 

        public void setFigureOnField(Figure figure, int x, int y)
        {
            this.figures[x, y] = figure;
            Console.WriteLine(figures[x,y]);
            Console.ReadKey();
        }

        public void ShowField()
        {
          
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", GetFigure()[0, 0], GetFigure()[0, 1], GetFigure()[0, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", GetFigure()[1, 0], GetFigure()[1, 1], GetFigure()[1, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", GetFigure()[2, 0], GetFigure()[2, 1], GetFigure()[2, 2]);
        }
        public Figure[,] GetFigure()
        {
            return this.figures;
        }

        //public Field(int x)
        //{
        //    //MAX_COORDINATE = x;
        //    //figures = new Figure[MAX_COORDINATE, MAX_COORDINATE];

        //    for (int i = 0; i < figures.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < figures.GetLength(1); j++)
        //            figures[i, j] = Figure._;
        //    }
        //}
    }
}
