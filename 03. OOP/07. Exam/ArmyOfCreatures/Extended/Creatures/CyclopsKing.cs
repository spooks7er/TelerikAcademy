using System;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Extended.Specialties;

namespace ArmyOfCreatures.Extended.Creatures
{
    class CyclopsKing : Creature
    {
        public CyclopsKing() 
            : base(17, 13, 70, 18m)
        {
            this.AddSpecialty(new AddAttackWhenSkip(3));
            this.AddSpecialty(new DoubleAttackWhenAttacking(4));
            this.AddSpecialty(new DoubleDamage(1));
        }
    }
}
