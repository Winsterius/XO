using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XO.Model;
using XO.Controllers;


namespace XO
{
    class Program
    {
        static int x = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name of first player");
            Player p1 = new Player(Figure.X, Console.ReadLine());
            Console.WriteLine("Please enter the name of second player");
            Player p2 = new Player(Figure.O, Console.ReadLine());
            Game game = new Game(p1, p2);
            Field field = new Field(3);
            MoveController mc = new MoveController();
            CurrentMoveController cmc = new CurrentMoveController();

            while (true)
            {
                field.ShowField();
                mc.AskForMove(cmc.CheckCurrentMove());

                Console.Clear();
                
            }
            Console.ReadKey();
        }
    }
}
