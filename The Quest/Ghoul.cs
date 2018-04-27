using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    class Ghoul:Enemy
    {
        public Ghoul(Game game, Point location):base(game,location,10)
        {
            
        }

        public override void Move(Random random)
        {
            // HACK: override Ghoul's move method.
            //            The ghoul is the toughest enemy.It starts with 10 hit points, and
            //only moves and attacks if its hit points are greater than zero.
            //When it moves, there’s a two in three chance that it’ll move
            //toward the player, and a one in three chance that it’ll stand still.
            //If it’s near the player, it attacks the player with up to four hit
            //points of damage.

            Direction directionToMove;

            //if ghost is not near player, move.
            if (!NearPlayer() && HitPoints > 0)
            {
                //random check with 50% chance to move forward player
                if (random.Next(2) != 0)
                {
                    directionToMove = FindPlayerDirection(game.PlayerLocation);
                    base.Move(directionToMove, game.Boundaries);
                }
            }

            //if bat is nearby player, hit.
            if (NearPlayer() && HitPoints > 0)
                game.HitPlayer(4, random);
        }
    }
}
