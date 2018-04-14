using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    class RedPotion:Weapon,IPotion
    {
        public RedPotion(Game game, Point location) : base(game, location)
        {

        }

        public override string Name { get { return "Red Potion"; } }

        public bool Used { get; }

        public override void Attack(Direction direction, Random random)
        {
            //TODO: override attack method.
            //            The RedPotion class is very similar to BluePotion, except that its
            //Name property returns the string Red Potion, and its Attack()
            //method increases the player’s health by up to 10 hit points.
        }
    }
}
