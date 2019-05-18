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
        private int input;
        private bool correctEmty = true;
        

        Field field = new Field();
        public void AskForMove(Figure figure)
        {
            do
            {
                Console.WriteLine("Take a move");
                while (!int.TryParse(Console.ReadLine(), out input)) ;
                ConvertNumberToCoordinats(input);
                while (!CheckEmtyField(field.GetFiguresArray(), x, y, figure))
                {
                    if (!correctEmty) break;
                    while (!CheckCoordinate(x)) Console.WriteLine("Incorrect move");
                }
                field.setFigureOnField(figure, x, y);
            } while (!correctEmty);
        }
        public void ConvertNumberToCoordinats(int input)
        {
            switch (input) {

                case 1:
                    x = 2;
                    y = 0;
                    break;
                case 2:
                    x = 2;
                    y = 1;
                    break;
                case 3:
                    x = 2;
                    y = 2;
                    break;
                case 4:
                    x = 1;
                    y = 0;
                    break;
                case 5:
                    x = 1;
                    y = 1;
                    break;
                case 6:
                    x = 1;
                    y = 2;
                    break;
                case 7:
                    x = 0;
                    y = 0;
                    break;
                case 8:
                    x = 0;
                    y = 1;
                    break;
                case 9:
                    x = 0;
                    y = 2;
                    break;
                default:
                    x = -1;
                    y = -1;
                    break;
            }
        }
        bool CheckCoordinate(int i)
        {
            if (i < 0 || i >= field.getArrLength()) return false;            
            else return true;
        }
        bool CheckEmtyField(Figure[,] figs, int x, int y, Figure figure)
        {
            if (figs[x, y].Equals(Figure._)) { correctEmty = true; return true; }
            //if (figs[x, y].Equals(figure)) return false;
            else { correctEmty = false; return false; }
        }
    }
}
