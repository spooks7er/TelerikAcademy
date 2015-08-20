using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo
    {
        private uint milliliters;
        private UsageType usage;

        private decimal fullPrice = 0;

        public Shampoo(
            string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
            this.fullPrice = milliliters * price;
        }

        public uint Milliliters
        {
            get { return this.milliliters; }
            private set { this.milliliters = value; }
        }

        // TODO
        public override decimal Price
        {
            get { return this.fullPrice; }
        }

        public UsageType Usage
        {
            get { return this.usage; }
            private set { this.usage = value; }
        }

        public override string Print()
        {
            StringBuilder output = new StringBuilder();
            //output.AppendLine(base.Print());
            output.AppendLine(string.Format("- {0} - {1}:\n", this.Brand, this.Name).TrimEnd());
            output.AppendLine(string.Format("  * Price: ${0}", this.fullPrice).TrimEnd());
            output.AppendLine(string.Format("  * For gender: {0}", this.Gender).TrimEnd());
            output.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters).TrimEnd());
            output.AppendLine(string.Format("  * Usage: {0}", this.Usage).TrimEnd());
            return output.ToString().TrimEnd();
        }
    }
}
