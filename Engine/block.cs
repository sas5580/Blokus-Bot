using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Block //blocks are the pieces 
    {
        public int ID { get; set; }    // 2 DIGIT ID FOR SHAPE 1 DIGIT ID FOR ORIENTATION 
        public int Availability { get; set; }
        public int Size { get; set; }
        public int Owner { get; set; }

        public Block (int id, int isAvailable, int size, int player)
        {
            ID = id;           
            Availability = isAvailable;
            Size = size;
            Owner = player;
        }

        



    }
}
