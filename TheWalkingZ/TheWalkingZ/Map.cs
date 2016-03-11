using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;   

namespace TheWalkingZ
{
    public class Map
    {
        public string Name { get; set; }
        public Size CellSize { get; set; }
        public Size CellCount { get; set; }

        public Point GoalPosition { get; set; }

        public void draw (Graphics g)
        {
            throw new NotImplementedException();
        }

    }
}
