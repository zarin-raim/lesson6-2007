using System;

namespace StockSystemLibrary
{
    public class Stock
    {
        private Array products;
        
        public Stock()
        {
            products = new Array();
        }

        public Product GetProduct(int position)
        {
            return (Product)products.GetObject(position);
        }

        public void SetProducts(Product item)
        {
            int position;
            bool inStock = Find(item, out position);

            if (inStock)
            {
                Product product = (Product)products.GetObject(position);
                product.SetCount(product.GetCount() + item.GetCount());
                products.Rewrite(product, position);
            }
            else
            {
                products.Add(item, products.GetSize());
            }
        }

        public void RemoveProducts(Product item)
        {
            int position;
            bool inStock = Find(item, out position);

            if (inStock)
            {
                Product product = (Product)products.GetObject(position);

                if (product.GetCount() >= item.GetCount())
                {
                    product.SetCount(product.GetCount() - item.GetCount());
                }
                else
                    throw new NoProductException("Не достаточно товара!"); 

                products.Rewrite(product, position);
            }
        }


        public bool Find(Product data, out int position)
        {
            for (int i = 0; i < products.GetSize(); i++)
            {
                Product temp = (Product)products.GetObject(i);
                if(temp.GetName() == data.GetName())
                {
                    position = i;
                    return true;
                }
            }
            position = 0;
            return false;
        }

        public int GetSize()
        {
            return products.GetSize();
        }
    }
}
