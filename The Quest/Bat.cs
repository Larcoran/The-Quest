using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    class Bat:Enemy
    {
        public Bat(Game game,Point location):base(game,location,6)
        {

        }

        public override void Move(Random random)
        {
            //HACK: Write code for moving bat.
            //            The bat starts with six hit points.It’ll keep moving toward the
            //player and attacking as long as it has one or more hit
            //points.When it moves, there’s a 50 % chance that it’ll move
            //toward the player, and a 50 % chance that it’ll move in a random
            //direction.After the bat moves, it checks if it’s near the player—
            //if it is, then it attacks the player with up to two hit points of
            //damage.

            
            Direction directionToMove;

            //if bat is not near player, move.
            if (!NearPlayer()&&HitPoints>0)
            {
                //random check with 50% chance to move forward player
                if (random.Next(1) == 0)
                {
                    directionToMove = (Direction)random.Next(4);
                    base.location = Move(directionToMove, game.Boundaries);
                }
                else
                {
                    directionToMove = FindPlayerDirection(game.PlayerLocation);
                    base.location = Move(directionToMove, game.Boundaries);
                }
            }

            //if bat is nearby player, hit.
            if(NearPlayer()&&HitPoints>0)
                game.HitPlayer(2, random);
        }
    }
}
