namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Category : ICategory
    {
        private const int CategoryNameMaxSymbols = 15;
        private const int CategoryNameMinSymbols = 2;

        private string name;
        private ICollection<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            products = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Category name"));
                Validator.CheckIfStringLengthIsValid(value, CategoryNameMaxSymbols, CategoryNameMinSymbols, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", CategoryNameMinSymbols, CategoryNameMaxSymbols));
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!products.Contains(cosmetics))
            {
                throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
            else
            {
                products.Remove(cosmetics);
            }
        }

        public string Print()
        {
            var sortedProducts =
                products
                        .OrderBy(p => p.Brand)
                        .ThenByDescending(p => p.Price);
            
            var howManyProducts =
                                 products.Count == 1
                                 ? products.Count.ToString() + " product"
                                 : products.Count.ToString() + " products";

            var builder = new StringBuilder();
            builder.AppendLine(string.Format("{0} category - {1} in total", this.Name, howManyProducts));

            foreach (var product in sortedProducts)
            {
                builder.AppendLine(product.ToString());
            }

            return builder.ToString().Trim();
        }
    }
}