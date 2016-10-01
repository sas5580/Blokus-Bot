using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Grid
    {
        public int XLoc;
        public int YLoc;

        public int Owner { get; set;}    //owned by player n
        public int[] RelativeOccupancy = { 0, 0, 0, 0, 0, 0, 0, 0 };

        public bool IsStarter { get; set; }

        public Grid (int x, int y, int owner, bool starter)
        {
            XLoc = x;
            YLoc = y;
            Owner = owner;
            IsStarter = starter;
        }
    }
}
