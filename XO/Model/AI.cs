using System;


namespace XO.Model
{
    class AI
    {
        private Figure[,] figures;
        private Figure aIFigure;
        private Figure playerFigure;
        private int helpSetFigure;
        private int x;
        private int y;

        readonly Field field = new Field();
        readonly Random random = new Random();
        public AI(Figure playerFuigure)
        {
            if (playerFigure.Equals(Figure.X)) aIFigure = Figure.O;
            if (playerFigure.Equals(Figure.O)) aIFigure = Figure.X;
        }

        public AI(Figure[,] figures) => this.figures = figures;
        public void SetFigure(Figure figure) => this.aIFigure = figure; 

        public void TakingMove()
        {
            helpSetFigure = random.Next(1,3);
            if(GetCountOfFiguresInArray() == 8)
            {
                getEmtyIndices();
                field.setFigureOnField(aIFigure, this.x, this.y);
            }
            if (GetCountOfFiguresInArray() < 3)
            {
                if (figures[1, 1].Equals(Figure._)) field.setFigureOnField(aIFigure, 1, 1);
            }
            else if (figures[0, 0].Equals(Figure._)) field.setFigureOnField(aIFigure, 2, 2);

        }
        public int GetCountOfFiguresInArray()
        {
            int count = 0;
            foreach (Figure fig in this.figures) if (fig.Equals(Figure.X) || fig.Equals(Figure.O)) count++;
            return count;
        }
        public void getEmtyIndices()
        {
            for(int x = 0; x < figures.Rank; x++)
            {
                for (int y = 0; y < figures.Rank; y++)
                {
                    if (figures[x, y].Equals(Figure._))
                    {
                        this.x = x;
                        this.y = y;
                    }
                    
                }
            }    
        }
    }
}
