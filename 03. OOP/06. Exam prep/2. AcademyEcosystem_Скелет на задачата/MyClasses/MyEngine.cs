using System;
using System.Linq;

namespace AcademyEcosystem
{
    public class MyEngine : Engine
    {
        protected override void ExecuteBirthCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "deer":
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        this.AddOrganism(new Deer(name, position));
                        break;
                    }
                case "wolf": // added
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        this.AddOrganism(new Wolf(name, position));
                        break;
                    }
                case "lion": // added
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        this.AddOrganism(new Lion(name, position));
                        break;
                    }
                case "boar": // added
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        this.AddOrganism(new Boar(name, position));
                        break;
                    }
                case "zombie": // added
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        this.AddOrganism(new Zombie(name, position));
                        break;
                    }
                case "tree":
                    {
                        Point position = Point.Parse(commandWords[2]);
                        this.AddOrganism(new Tree(position));
                        break;
                    }
                case "bush":
                    {
                        Point position = Point.Parse(commandWords[2]);
                        this.AddOrganism(new Bush(position));
                        break;
                    }
                case "grass": // added
                    {
                        Point position = Point.Parse(commandWords[2]);
                        this.AddOrganism(new Grass(position));
                        break;
                    }
            }
        }
    }
}