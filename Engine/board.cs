﻿using System;
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
                for(int j=0; j<14l j++)
                {
                    TheBoard[i, j].XLoc = i;
                    TheBoard[i, j].YLoc = j;
                    if(i==)
                }
            }

        }

        private void AddtoBoard(Block entry)
        {

        }


    }


}
