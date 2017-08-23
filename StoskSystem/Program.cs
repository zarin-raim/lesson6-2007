using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockSystemLibrary;

namespace StoskSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();

            Product item = new Product("Кирпичи", 4);
            Product item2 = new Product("Кирпичи", 3);

            Product item3 = new Product("Картошка", 10);

            stock.SetProducts(item);
            stock.SetProducts(item2);
            stock.SetProducts(item3);

            Console.ReadLine();
        }
    }
}
