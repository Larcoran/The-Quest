using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    class Sword:Weapon
    {
        public Sword(Game game,Point location):base(game,location)
        {

        }

        public override string Name { get { return "Sword"; } }

        public override void Attack(Direction direction, Random random)
        {
            //TODO: override attack method.
            //            The sword is the first weapon the player picks up.It’s got a wide
            //angle of attack: if he attacks up, then it first tries to attack an
            //enemy that’s in that direction. If there’s no enemy there, it looks
            //in the direction that’s clockwise from the original attack and
            //attacks any enemy there.If it still fails to hit, then it attempts to
            //attack an enemy counterclockwise from the original direction of
            //attack.It’s got a radius of 10, and causes 3 points of damage.
        }
    }
}
