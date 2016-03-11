using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWalkingZ
{
    public class Player
    {
        public Point Position { get; set; }
        public PowerUp ActivePowerUp { get; set; }
        public Cell CurrentCell { get; set; }
        public int HitPoints { get; set; }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }

        public void Interaction(int KeyCode)
        {
            throw new NotImplementedException();
        }
    }
}
