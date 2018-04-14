using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    class Ghost:Enemy
    {
        public Ghost(Game game, Point location):base(game,location,8)
        {

        }

        public override void Move(Random random)
        {
            //TODO: override ghost's move method.
            //            The ghost is harder to defeat than the bat. But like the bat, it will only
            //move and attack if its hit points are greater than zero. It starts with
            //eight hit points. When it moves, there’s a one in three chance that it’ll
            //move toward the player, and a two in three chance that it’ll stand still.
            //If it’s near the player, it attacks the player with up to three hit points
            //of damage.
        }
    }
}
