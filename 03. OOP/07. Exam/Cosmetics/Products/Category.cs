using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;
using Cosmetics.Common;
namespace Cosmetics.Products
{
    class Category : ICategory
    {
        private const int nameMinLen = 2;
        private const int nameMaxLen = 15;

        private string name;
        private List<IProduct> prodList = new List<IProduct>();

        public Category(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                //CheckIfStringLengthIsValid(this.name, nameMaxLen, nameMinLen, string message = null)

                if (value.Length < nameMinLen || value.Length > nameMaxLen)
                {
                    throw new IndexOutOfRangeException(string.Format(
                        "Category name must be between {0} and {1} symbols long!", nameMinLen, nameMaxLen));
                }
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            prodList.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (prodList.IndexOf(cosmetics) == -1)
            {
                throw new IndexOutOfRangeException(string.Format(
                "Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
            while (prodList.IndexOf(cosmetics) != -1)
            {
                prodList.Remove(cosmetics);
            }
        }

//{category name} category – {number of products} products/product in total
//- {product brand} – {product name}:
//  * Price: ${product price}
//  * For gender: Men/Women/Unisex
//  * Ingredients: {product ingredients, separated by “, “} (when applicable)
//- {product brand} – {product name}:
//  * Price: ${product price}
//  * For gender: {product gender}
//  * Quantity: {product quantity} ml (when applicable)
//  * Usage: EveryDay/Medical (when applicable)

        // TODO
        public string Print()
        {
            StringBuilder output = new StringBuilder();

            if (this.prodList.Count == 1)
            {
                output.AppendFormat("{0} category - {1} product in total\n", this.Name, this.prodList.Count.ToString());
            }
            else
            {
                output.AppendFormat("{0} category - {1} products in total\n", this.Name, this.prodList.Count.ToString());
            }

            var orderedProds = this.prodList
                .OrderBy(p => p.Brand).ThenByDescending(p => p.Price);
            foreach (var prod in orderedProds)
            {
                output.AppendLine(prod.Print().TrimEnd());
            }
            return output.ToString().TrimEnd();
        }
    }
}
