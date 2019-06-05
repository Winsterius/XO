using System;
using XO.View;
using XO.Model;
using XO.Controllers;


namespace XO
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateTheGame createTheGame = new CreateTheGame();
            //createTheGame.Menu();

            AI ai = new AI();
            Field field = new Field(3);
            ConsoleView cv = new ConsoleView();
            Figure[,] figs = { {Figure._, Figure._, Figure.X } ,
                               {Figure._, Figure.X, Figure._ } ,
                               {Figure._, Figure._, Figure._ } };
            ai.CheckPossiblyWin(figs);
            Console.WriteLine(figs.Length);
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", field.GetFiguresArray()[0, 0], field.GetFiguresArray()[0, 1], field.GetFiguresArray()[0, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", field.GetFiguresArray()[1, 0], field.GetFiguresArray()[1, 1], field.GetFiguresArray()[1, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" {0,1} | {1,1} | {2,1} ", field.GetFiguresArray()[2, 0], field.GetFiguresArray()[2, 1], field.GetFiguresArray()[2, 2]);

            Console.ReadKey();

        }        
    }
}
