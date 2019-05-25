using System;
using XO.View;


namespace XO.Model
{
    class AI
    {

        private static Figure aIFigure;
        private string playerFigure;
        private int x;
        private int y;

        readonly Field field = new Field();
        readonly Random random = new Random();
        public AI() { }
        public AI(string playerFuigure)
        {
            playerFigure = ConsoleView.figurePlayerInput;
            if (playerFigure.Equals("X")) aIFigure = Figure.O;
            if (playerFigure.Equals("O")) aIFigure = Figure.X;
        }


        public void SetFigure(Figure figure) => aIFigure = figure; 

        public void TakingMove()
        {
            
            if(GetCountOfFiguresInArray() == 8)
            {
                getEmtyIndices();
                field.setFigureOnField(aIFigure, this.x, this.y);
            }
            if (GetCountOfFiguresInArray() < 3)
            {
                if (Field.figures[1, 1].Equals(Figure._)) field.setFigureOnField(aIFigure, 1, 1);
            }
            if (Field.figures[0, 0].Equals(Figure._)) field.setFigureOnField(aIFigure, 2, 2);

        }
        public int GetCountOfFiguresInArray()
        {
            int count = 0;
            foreach (Figure fig in Field.figures) if (fig.Equals(Figure.X) || fig.Equals(Figure.O)) count++;
            return count;
        }
        public void getEmtyIndices()
        {
            for(int x = 0; x < Field.figures.Rank; x++)
            {
                for (int y = 0; y < Field.figures.Rank; y++)
                {
                    if (Field.figures[x, y].Equals(Figure._))
                    {
                        this.x = x;
                        this.y = y;
                    }
                    
                }
            }    
        }
        public int GetRandomNumber(int i) => random.Next(1, i + 1);
        public Figure getAIFigure() => aIFigure;
    }
}
