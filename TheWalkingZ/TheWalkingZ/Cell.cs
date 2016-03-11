using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWalkingZ
{
    public class Cell
    {
        public Point Index { get; set; }
        public Point Position { get; set; } 
        public CellType Type { get; set;}
        
        public void draw (Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
