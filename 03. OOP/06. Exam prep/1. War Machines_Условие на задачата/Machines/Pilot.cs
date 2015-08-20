using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarMachines.Interfaces;
namespace WarMachines.Machines
{
    class Pilot : IPilot
    {
        private string name;
        private List<IMachine> machineList = new List<IMachine>();

        public Pilot(string name)
        {
            this.Name = name;
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

        public void AddMachine(IMachine machine)
        {
            this.machineList.Add(machine);
        }

        public string Report()
        {
            StringBuilder output = new StringBuilder();

            string numOfMachines = "no machines";

            var orderredMachines = this.machineList
                        .OrderBy(m => m.HealthPoints)
                        .ThenBy(m => m.Name)
                        .ToList();

            if (orderredMachines.Count != 0)
            {
                if (orderredMachines.Count == 1)
                {
                    numOfMachines = orderredMachines.Count + " machine\n";
                }
                else
                {
                    numOfMachines = orderredMachines.Count + " machines\n";
                }

                output.AppendFormat("{0} - {1}", this.Name, numOfMachines);

                foreach (var machine in orderredMachines)
                {
                    output.AppendLine(machine.ToString().TrimEnd());
                }
                return output.ToString().TrimEnd();
            }

            output.AppendFormat("{0} - {1}", this.Name, numOfMachines);
            return output.ToString().TrimEnd();
        }
    }
}