using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWalkingZ
{
    public class Enemy
    {
        public Point Position { get; set;}
        public int HitPoints { get; set; }

        public Enemy(Point position, int hitPoints)
        {
            this.Position = position;
            this.HitPoints = hitPoints;
        }
        public void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }

        public void Attack(Player player)
        {
            throw new NotImplementedException();
        }

    }
}
