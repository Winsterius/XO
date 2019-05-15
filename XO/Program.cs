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
            Field field = new Field(3);
            MoveController mc = new MoveController();

            field.ShowField();
            

            while(x != 9)
            {
                mc.AskForMove(Figure.X);
                x++;
            }

            Console.ReadKey();
        }
    }
}
