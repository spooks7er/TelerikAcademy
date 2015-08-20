using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class MyInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString,
            string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "armor":
                    item = new Armor(itemNameString, itemLocation);
                    break;
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    break;
            }
            return item;
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "shopkeeper":
                    person = new Shopkeeper(personNameString, personLocation);
                    break;
                case "traveller":
                    person = new Traveller(personNameString, personLocation);
                    break;
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    break;
            }
            return person;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "town":
                    location = new Town(locationName);
                    break;
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;
                default:
                    break;
            }
            return location;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            if (commandWords[1] == "gather" || commandWords[1] == "craft")
            {
                switch (commandWords[1])
                {
                    case "gather":
                        HandleGatherInteraction(actor, commandWords[2]);
                        break;
                    case "craft"://kiro craft weapon craftedWeapon
                        HandleCraftInteraction(actor, commandWords[2], commandWords[3]);
                        break;
                    default:
                        break;
                }
            }
            base.HandlePersonCommand(commandWords, actor);
        }

        private void HandleGatherInteraction(Person actor, string itemName)
        {
            bool hasWeapon = false;
            bool hasArmor = false;

            foreach (var item in actor.ListInventory())
            {
                if (item.ItemType == ItemType.Weapon)
                {
                    hasWeapon = true;
                }
                if (item.ItemType == ItemType.Armor)
                {
                    hasArmor = true;
                }
            }
            if (actor.Location.LocationType == LocationType.Forest && hasWeapon)
            {
                AddToPerson(actor, new Wood(itemName));
            }
            else if (actor.Location.LocationType == LocationType.Mine && hasArmor)
            {
                AddToPerson(actor, new Iron(itemName));
            }
        }

        private void HandleCraftInteraction(Person actor, string itemType, string itemName)
        {
            bool hasWood = false;
            bool hasIron = false;

            foreach (var item in actor.ListInventory())
            {
                if (item.ItemType == ItemType.Wood)
                {
                    hasWood = true;
                }
                if (item.ItemType == ItemType.Iron)
                {
                    hasIron = true;
                }
            }

            switch (itemType)
            {
                case "armor":
                    if (hasIron)
                    {
                        AddToPerson(actor, new Armor(itemName));
                    }
                    break;

                case "weapon":
                    if (hasIron && hasWood)
                    {
                        AddToPerson(actor, new Weapon(itemName));
                    }
                    break;

                default:
                    break;
            }
        }
    }
}