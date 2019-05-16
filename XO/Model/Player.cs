using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.Model
{
    class Player
    {
        private string name;
        private Figure figure;

        Player(Figure figure, string name)
        {
            this.name = name;
            this.figure = figure;
        }

        public string GetName()
        {
            return name;
        }
        public Figure GetFigure()
        {
            return figure;
        }
    }
}
