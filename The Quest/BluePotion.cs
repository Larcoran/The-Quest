using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    class BluePotion:Weapon,IPotion
    {
        public BluePotion(Game game, Point location) : base(game, location)
        {

        }

        public override string Name { get { return "Blue Potion"; } }

        public bool Used { get; private set; }

        public override void Attack(Direction direction, Random random)
        {
            //HACK: override attack method.
            //            The BluePotion class’s Name property should return the string
            //Blue Potion.Its Attack() method will be called when the
            //player uses the blue potion—it should increase the player’s health by
            //up to five hit points by calling the IncreasePlayerHealth()
            //method.After the player uses the potion, the potion’s Used()
            //method should return true.

            game.IncreasePlayerHealth(5,random);
            Used = true;
        }
    }
}
