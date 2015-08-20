using System;
using System.Collections.Generic;

namespace AcademyRPG
{
    public class Giant : Character, IFighter, IGatherer
    {
        private int hp = 200;
        private int ap = 150;
        private int dp = 80;

        private static int owner = 0;

        private bool hasStoneBuff = false;

        public Giant(string name, Point position)
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
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (!hasStoneBuff)
                {
                    this.AttackPoints += 100;
                    hasStoneBuff = true;
                }
                return true;
            }

            return false;
        }
    }
}
