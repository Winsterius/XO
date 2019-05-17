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
            do
            {
                while (!int.TryParse(Console.ReadLine(), out x) || !CheckCoordinate(x)) Console.WriteLine("Incorrect move");
                while (!int.TryParse(Console.ReadLine(), out y) || !CheckCoordinate(y)) Console.WriteLine("Incorrect move");
            }while (CheckEmtyField(field.GetFiguresArray(), this.x, this.y));
            field.setFigureOnField(figure, x, y);         
        }
        bool CheckCoordinate(int i)
        {
            if (i < 0 || i >= field.getArrLength()) return false;            
            else return true;
        }
        bool CheckEmtyField(Figure[,] figs, int x, int y)
        {
            if (figs[x, y].Equals(Figure._)) return false;
            else return true;
        }
    }
}
