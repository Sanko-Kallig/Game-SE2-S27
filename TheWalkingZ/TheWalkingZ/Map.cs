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

        public Map(string name, Size cellSize, Size cellCount, Point goalPosition)
        {
            this.Name = name;
            this.CellSize = cellSize;
            this.CellCount = cellCount;
            this.GoalPosition = goalPosition;
        }

        public void draw (Graphics g)
        {
            throw new NotImplementedException();
        }

    }
}
