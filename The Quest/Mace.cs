using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    class Mace:Weapon
    {
        public Mace(Game game, Point location) : base(game, location)
        {

        }

        public override string Name { get { return "Mace"; } }

        public override void Attack(Direction direction, Random random)
        {
            //TODO: override attack method.
            //            The mace is the most powerful weapon in the dungeon. It doesn’t
            //matter in which direction the player attacks with it—since he
            //swings it in a full circle, it’ll attack any enemy within a radius of
            //20 and cause up to 6 points of damage.
        }
    }
}
