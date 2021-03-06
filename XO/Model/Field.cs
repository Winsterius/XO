﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.Model
{
    public class Field
    {
        private static Figure[,] figures;

        public Field() { }
        public Field(int MAX_COORDINATE)
        {
            figures = new Figure[MAX_COORDINATE, MAX_COORDINATE];
        }
        public Figure[,] GetFiguresArray() => figures; 

        public void setFigureOnField(Figure figure, int x, int y)
        {
            figures[x, y] = figure;
        }
       
    }
}
