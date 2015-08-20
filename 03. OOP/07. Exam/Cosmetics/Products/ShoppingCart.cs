using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    class ShoppingCart : IShoppingCart
    {
        private List<IProduct> prodList = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            prodList.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            prodList.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return prodList.Contains(product);
        }

        public decimal TotalPrice()
        {
            return prodList.Sum(p => p.Price);
        }
    }
}
