namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Cosmetics.Contracts;
    using Cosmetics.Common;

    class Toothpaste : Product, IProduct, IToothpaste
    {
        private const int IngredientsMinLength = 4;
        private const int IngredientsMaxLength = 12;

        private string ingredients;
        private IList<string> ingredientList;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredientsList)
            :base(name, brand, price, gender)
        {
            this.ingredientList = ingredientsList;

            ValidationListOfIngredients(ingredientsList);
        }

        public string Ingredients
        {
            get
            {
                return this.ingredients;
            }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Each ingredient"));
                Validator.CheckIfStringLengthIsValid(value, IngredientsMaxLength, IngredientsMinLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", IngredientsMinLength, IngredientsMaxLength));

                this.ingredients = value;
            }
        }

        private void ValidationListOfIngredients(IList<string> ingredientsList)
        {
            foreach (var item in ingredientsList)
            {
                this.Ingredients = item;
            }            
        }

        private string MakeStringFromListOfIngredients(IList<string> ingredientsList)
        {
            return string.Join(", ", ingredientsList);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString());
            builder.AppendLine(string.Format(" * Ingredients: {0}", this.MakeStringFromListOfIngredients(ingredientList)));

            return builder.ToString().Trim();
        }
    }
}