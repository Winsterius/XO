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

        public void AskForMove2(Figure figure)
        {
            Console.WriteLine("Take a move");
            if (!int.TryParse(Console.ReadLine(), out input) || input < 0 || input > 9) AskForMove2(figure);
            else
            {
                ConvertNumberToCoordinats(input);
                while (CheckEmtyField(field.GetFiguresArray(), x, y, figure)) AskForMove2(figure);
                field.setFigureOnField(figure, x, y);
            }
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
            if (i < 0 || i >= 9) return true;            
            else return false;
        }
        bool CheckEmtyField(Figure[,] figs, int x, int y, Figure figure)
        {
            if (figs[x, y].Equals(Figure._)) return false; 

            else return true; 
        }
    }
}
