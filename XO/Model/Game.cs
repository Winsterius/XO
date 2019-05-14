using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.Model
{
    class Game
    {
        private Player[] players;
        private Field field;
        private string name;

        Game(Player[] players, Field field, string name)
        {
            this.players = players;
            this.field = field;
            this.name = name;
        }
        public Player[] GetPlayers()
        {
            return players;
        }
        public Field GetField()
        {
            return field;
        }
        public string GetName()
        {
            return name;
        }



    }
}
