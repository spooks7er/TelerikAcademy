﻿using System;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Extended.Specialties;

namespace ArmyOfCreatures.Extended.Creatures
{
    class WolfRaider : Creature
    {
        public WolfRaider()
            : base(8, 5, 10, 3.5m)
        {
            this.AddSpecialty(new DoubleDamage(7));
        }
    }
}
