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

        public Figure[,] figures; 

        public void setFigureOnField(Figure figure, int x, int y)
        {
            figures[x, y] = figure;
        }

        public void ShowField()
        {
          
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ",figures[0,0],figures[0,1],figures[0,2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ",figures[1, 0], figures[1, 1], figures[1, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ",figures[2, 0], figures[2, 1], figures[2, 2]);
        }

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
