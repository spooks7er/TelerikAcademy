using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    class Toothpaste : Product, IToothpaste
    {
        private const int ingMinLen = 4;
        private const int ingMaxLen = 12;

        private string ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.Ingredients = CheckIngredinets(ingredients);
        }

        public string Ingredients
        {
            get { return this.ingredients; }
            private set { this.ingredients = value; }
        }

        private string CheckIngredinets(IList<string> ingredientsList)
        {
            foreach (var item in ingredientsList)
            {
                if (item.Length < ingMinLen || item.Length > ingMaxLen)
                {
                    throw new IndexOutOfRangeException(string.Format(
                        "Each ingredient must be between {0} and {1} symbols long!", ingMinLen, ingMaxLen));
                }
            }
            return this.ingredients = string.Join(", ", ingredientsList);
        }

        public override string Print()
        {
            StringBuilder output = new StringBuilder();
            //output.AppendLine(base.Print());
            output.AppendLine(string.Format("- {0} - {1}:\n", this.Brand, this.Name).TrimEnd());
            output.AppendLine(string.Format("  * Price: ${0}", this.Price).TrimEnd());
            output.AppendLine(string.Format("  * For gender: {0}", this.Gender).TrimEnd());
            output.AppendLine(string.Format("  * Ingredients: {0}", this.Ingredients).TrimEnd());
            return output.ToString().TrimEnd();
        }
    }
}
