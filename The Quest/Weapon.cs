using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }

        public Weapon (Game game, Point location):base(game,location)
        {
            PickedUp = false;
        }

        public void PickUpWeapon() { PickedUp = true; }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction,int radius, int damage,Random random)
        {
            Point target = game.PlayerLocation;
            for(int distance = 0; distance <radius;distance++)
            {
                foreach(Enemy enemy in game.Enemies)
                {
                    if(Nearby(enemy.Location,target,distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                } 
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }

        public Point Move(Direction direction,Point target, Rectangle boundaries)
        {
            //HACK: add second point called: "target" to existing method
            target = Move(direction,boundaries);
            return target;
        }

        public bool Nearby(Point locationToCheck, Point target, int distance )
        {
            //HACK: add second point called: "target" to existing method
            if (Math.Abs(target.X - locationToCheck.X) < distance && Math.Abs(target.Y - locationToCheck.Y) < distance)
                return true;
            else return false;
        }

        //        The Nearby() method in the Mover class takes only two parameters,
        //a Point and an int , compares the Point to the current location, and
        //returns true if the Point is near the location.For the DamageEnemy
        //calculation, you’ll need to add an overloaded Nearby() method that
        //compares two points and returns true if they’re within the specified
        //distance of each other.

        //  You’ll also need an overloaded Move method to
        //move a Point in a direction and return the new Point.See if you can
        //figure out how to modify the Nearby() and Move() methods that we
        //gave you so that the overloaded methods don’t duplicate any code.

    }
}
