using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.Model
{
    public class Player
    {
        private string name;
        private Figure figure;

        public Player(Figure f, string n)
        {
            name = n;
            figure = f;
        }

        public string GetName()
        {
            return name;
        }
    }
}
