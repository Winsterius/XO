using System;
using XO.View;


namespace XO.Model
{
    class AI
    {

        private static Figure aIFigure = Figure.X;
        private string playerFigure;
        private int x;
        private int y;
        private int helper;

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
            helper = random.Next(1,4);
            if(GetCountOfFiguresInArray() == 8)
            {
                getEmtyIndices();
                field.setFigureOnField(aIFigure, this.x, this.y);
            }
            CheckPossiblyWin(Field.figures);            //?? need tests
            if (GetCountOfFiguresInArray() <= 4 && helper == 1)
            {
                if (Field.figures[1, 1].Equals(Figure._)) field.setFigureOnField(aIFigure, 1, 1);
            }
            else if (Field.figures[0, 0].Equals(Figure._)) field.setFigureOnField(aIFigure, 2, 2);

        }
        public void CheckPossiblyWin(Figure[,] figures)
        {
            int count = 0;
            for (int i = 0; i <= figures.Rank; i++)
			{               
                for (int j = 0; j <= figures.Rank; j++) if (figures[i, j].Equals(aIFigure)) count++;

                if (count == 2 ) for (int j = 0; j <= figures.Rank; j++) if(Field.figures[i, j].Equals(Figure._)) field.setFigureOnField(aIFigure, i, j);
                count = 0;
            }
            count = 0; 
            for (int j = 0; j <= figures.Rank; j++)
			{
                               
                for (int i = 0; i <= figures.Rank; i++)  if(figures[i, j].Equals(aIFigure)) count++;
                if (count == 2 ) for (int i = 0; i <= figures.Rank; i++) if(Field.figures[i, j].Equals(Figure._)) field.setFigureOnField(aIFigure, i, j);
                count = 0;
            }
            count = 0;
            for (int i = 0, j = 0; i <= figures.Rank; i++, j++)
			{
                
                if(figures[i, j].Equals(aIFigure)) count++;
                if (count == 2) for ( i = 0; i <= figures.Rank; i++, j++){
                    j = 0;
                    if (Field.figures[i, j].Equals(Figure._)) field.setFigureOnField(aIFigure, i, j);
                        count = 0;
                }
                
            }
            count = 0;
            for (int i = 0, j = 2; i <= figures.Rank; i++, j--)
			{               
                
                if(figures[i, j].Equals(aIFigure)) count++;
                if (count == 2) for (i = 0; i <= figures.Rank; i++, j--) {
                    j = 0;
                    if (Field.figures[i, j].Equals(Figure._)) field.setFigureOnField(aIFigure, i, j);
                        count = 0;
                }
			}
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
