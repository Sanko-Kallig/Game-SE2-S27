using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheWalkingZ
{
    public class World
    {
        List<Enemy> Enemies { get; set; }
        List<Map> Maps { get; set; }
        List<PowerUp> PowerUps { get; set; }

        Player CurrentPlayer { get; set; }

        public World()
        {

        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
