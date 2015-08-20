using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Rock : StaticObject, IResource
    {
        protected int Size { get; private set; }

        public Rock(int size, Point position)
            : base(position)
        {
            this.Size = size;
            this.HitPoints = size;
        }

        public ResourceType Type
        {
            get
            {
                return ResourceType.Stone;
            }
        }

        public int Quantity
        {
            get
            {
                return this.Size / 2;
            }
        }

    }
}
