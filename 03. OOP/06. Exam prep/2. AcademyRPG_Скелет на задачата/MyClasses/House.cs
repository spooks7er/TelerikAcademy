using System;

namespace AcademyRPG
{
    public class House : StaticObject
    {
        private int hp = 500;

        public House(Point position, int owner) 
            : base(position, owner)
        {
            this.HitPoints = this.hp;
        }
    }
}
