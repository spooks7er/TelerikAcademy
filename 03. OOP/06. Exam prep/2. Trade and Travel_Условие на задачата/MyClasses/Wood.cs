﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class Wood : Item
    {
        const int DefaultValue = 2;

        public Wood(string name, Location location = null)
            : base(name, Wood.DefaultValue, ItemType.Wood, location)
        {
        }

        static List<ItemType> GetComposingItems()
        {
            return new List<ItemType>() { ItemType.Wood };
        }

        public override void UpdateWithInteraction(string interaction)
        {
            switch (interaction)
            {
                case "drop":
                    HandleDrop(); break;
                default:
                    break;
            }

        }

        private void HandleDrop()
        {
            if (this.Value > 0)
            {
                this.Value--;
            }
        }
    }
}
