namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Contracts;

    class ShoppingCart : IShoppingCart
    {
        ICollection<IProduct> productsInShoppingCart;

        public ShoppingCart()
        {
            productsInShoppingCart = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            productsInShoppingCart.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            productsInShoppingCart.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            if (productsInShoppingCart.Contains(product))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var item in productsInShoppingCart)
            {
                totalPrice += item.Price;
            }

            return totalPrice;
        }
    }
}
