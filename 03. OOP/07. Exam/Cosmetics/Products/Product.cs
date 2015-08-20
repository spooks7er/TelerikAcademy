using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;
using Cosmetics.Common;


//CreateShampoo
//(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
namespace Cosmetics.Products
{
    public abstract class Product : IProduct
    {
        private const int nameMinLen = 3;
        private const int nameMaxLen = 10;
        private const int brandMinLen = 2;
        private const int brandMaxLen = 10;

        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value.Length < nameMinLen || value.Length > nameMaxLen)
                {
                    throw new IndexOutOfRangeException(string.Format(
                        "Product name must be between {0} and {1} symbols long!", nameMinLen, nameMaxLen));
                }
                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }
            private set
            {
                if (value.Length < brandMinLen || value.Length > brandMaxLen)
                {
                    throw new IndexOutOfRangeException(string.Format(
                        "Product brand must be between {0} and {1} symbols long!", brandMinLen, brandMaxLen));
                }
                this.brand = value;
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }
            private set { this.price = value; }

        }

        public GenderType Gender
        {
            get { return this.gender; }
            private set { this.gender = value; }
        }

        public abstract string Print();
    }
}
