namespace EntityFrameworkHw
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Linq;

    public partial class Employee
    {
        public virtual ICollection<Territory> TerritoriesSet
        {
            get
            {
                var entSet = new EntitySet<Territory>();
                entSet.AddRange(this.Territories);
                return entSet;
            }
            set
            {
                this.Territories = value;
            }
        }
    }
}
