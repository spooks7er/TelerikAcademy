﻿using System;
using System.Globalization;
using System.Threading;
using System.Linq;
using ArmyOfCreatures.Console.Commands;
using ArmyOfCreatures.Extended;
using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Battles;
using System.Collections.Generic;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Extended.Creatures;

namespace ArmyOfCreatures.Extended.Engine
{
    class MyCreaturesFactory : CreaturesFactory, ICreaturesFactory
    {
        public override Creature CreateCreature(string name)
        {
            switch (name)
            {
                case "Angel":
                    return new Angel();
                case "Archangel":
                    return new Archangel();
                case "ArchDevil":
                    return new ArchDevil();
                case "Behemoth":
                    return new Behemoth();
                case "Devil":
                    return new Devil();
                case "AncientBehemoth":
                    return new AncientBehemoth();
                case "CyclopsKing":
                    return new CyclopsKing();
                case "Goblin":
                    return new Goblin();
                case "Griffin":
                    return new Griffin();
                case "WolfRaider":
                    return new WolfRaider();
                default:
                    throw new ArgumentException(
                        string.Format(CultureInfo.InvariantCulture, "Invalid creature type \"{0}\"!", name));
            }
        }
    }
}
