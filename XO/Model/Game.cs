using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.Model
{
    public class Game
    {
        public static Player[] players;
        
        

        public Game() { }
        public Game(Player player1, Player player2)
        {
            players = new Player[] { player1, player2 };

        }
        public string GetNamePlayer(Figure figure)
        {
            if (figure.Equals(Figure.X)) return players[0].GetName();
            if (figure.Equals(Figure.O)) return players[1].GetName();
            else return "I am this idiot who had written this code";
        }

    }
}
