using System;
using System.Collections.Generic;

namespace AcademyRPG
{
    public class Knight : Character, IFighter
    {
        private int hp = 100;
        private int ap = 100;
        private int dp = 100;

        public Knight(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = hp;
        }

        public int AttackPoints
        {
            get { return ap; }
            private set { this.ap = value; }

        }

        public int DefensePoints
        {
            get { return dp; }
            private set { this.dp = value; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
