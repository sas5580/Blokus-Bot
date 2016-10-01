using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class AvailableBlocks
    {
        public Block[] Inventory = new Block[218];

        public Block Details { get; set; }

        public void InitializeBlocks()
        {
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 218; i++)
                {
                    Inventory[i].Availability = 1;
                    Inventory[i].ID = i;
                    Inventory[i].Owner = j;
                }
            }
        }

        public void BlockUsed(int[] Inventory, Block details )
        {

        }

        



    }
}
