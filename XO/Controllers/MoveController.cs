using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XO.Model;

namespace XO.Controllers
{
    public class MoveController
    {
        private int x;
        private int y;

        Field field = new Field();
        public void AskForMove(Figure figure)
        {
            Console.WriteLine("Take a move");
            while (!int.TryParse(Console.ReadLine(), out x)) Console.WriteLine("Incorrect move");
            while (!int.TryParse(Console.ReadLine(), out y)) Console.WriteLine("Incorrect move");

            field.setFigureOnField(figure, x, y);
            
        }
        void CheckCoordinate() { }

    }
}
