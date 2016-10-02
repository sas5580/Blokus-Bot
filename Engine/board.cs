using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Board
    {
        private Grid[,] TheBoard = new Grid[14,14];
        public Grid Status;

        private void buildBoard()
        {
            for(int i = 0; i < 14; i++)
            {
                for(int j=0; j<14; j++)
                {
                    TheBoard[i, j].XLoc = i;
                    TheBoard[i, j].YLoc = j;
                    //if(i==)
                }
            }
            TheBoard[4, 4].IsStarter = true;
            TheBoard[9, 9].IsStarter = true;
        }

        private void AddtoBoard(Block entry)
        {

        }
    }
}
