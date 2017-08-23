using System;
using System.Collections.Generic;
using System.Text;

namespace StockSystemLibrary
{
    public class Product
    {
        private string _name;
        private int _count;

        public Product() { }

        public Product(string name, int count)
        {
            _name = name;
            _count = count;
        }

        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }

        public void SetCount(int count)
        {
            _count = count;
        }
        public int GetCount()
        {
            return _count;
        }
    }
}
