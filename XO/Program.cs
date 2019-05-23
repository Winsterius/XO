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
            CreateTheGame createTheGame = new CreateTheGame();
            createTheGame.Menu();
          
        }        
    }
}
