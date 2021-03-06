﻿using System;
using System.Collections.Generic;
using System.Linq;
using WarMachines.Interfaces;
using System.Text;
namespace WarMachines.Machines
{
    class Fighter : IFighter, IMachine
    {
        private string name;
        private double attackPoints;
        private double defensePoints;
        private double healthPoints;

        private string type = "Fighter";

        private IPilot pilot;

        private IList<string> targets = new List<string>();

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = 200;
            this.StealthMode = stealthMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            if (StealthMode)
            {
                StealthMode = false;
                return;
            }
            StealthMode = true;
        }


        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Property Name cannot be null.");
                }
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Property Pilot cannot be null.");
                }
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Property HealthPoints cannot be null.");
                }
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Property AttackPoints cannot be null.");
                }
                this.attackPoints = value;
            }
        }

        public double DefensePoints
        {
            get
            {
                return this.defensePoints;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Property DefensePoints cannot be null.");
                }
                this.defensePoints = value;
            }
        }

        public IList<string> Targets
        {
            get { return this.targets; }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }

        //- (machine name)
        //*Type: (“Tank”/”Fighter”)
        //*Health: (machine health points)
        //*Attack: (machine attack points)
        //*Defense: (machine defense points)
        //*Targets: (machine target names/”None” – comma separated)
        //*Defense: (“ON”/”OFF” – when applicable)
        //*Stealth: (“ON”/”OFF” – when applicable)

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendLine(string.Format("- {0}", this.Name).TrimEnd());
            output.AppendLine(string.Format(" *Type: {0}", this.type).TrimEnd());
            output.AppendLine(string.Format(" *Health: {0}", this.HealthPoints).TrimEnd());
            output.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints).TrimEnd());
            output.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints).TrimEnd());

            string targetsStr = "None";
            if (this.targets.Count != 0)
            {
                targetsStr = string.Join(", ", this.targets).TrimEnd();
            }

            string stelOnOf = "OFF";
            if (StealthMode)
            {
                stelOnOf = "ON";
            }
            output.AppendLine(string.Format(" *Targets: {0}", targetsStr).TrimEnd());
            output.AppendLine(string.Format(" *Stealth: {0}", stelOnOf).TrimEnd());

            return output.ToString().TrimEnd();
        }
    }
}