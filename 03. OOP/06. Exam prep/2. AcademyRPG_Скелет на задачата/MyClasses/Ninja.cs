using System;
using System.Linq;
using System.Collections.Generic;

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {
        private int hp = 1;
        private int ap = 0;
        private int dp = int.MaxValue;

        public Ninja(string name, Point position, int owner)
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
            var targetsOrderedByHP = availableTargets
                .OrderBy(t => t.HitPoints)
                .ToList();

            for (int i = 0; i < targetsOrderedByHP.Count; i++)
            {
                if (targetsOrderedByHP[i].Owner != this.Owner && targetsOrderedByHP[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }

            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += resource.Quantity * 2;
                return true;
            }

            return false;
        }
    }
}