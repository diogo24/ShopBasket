using Shop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Bread : IProduct
    {
        public const int ID = 1;

        public int Id => ID;
        public decimal Price { get; private set; }

        public Bread(decimal price)
        {
            Price = price;
        }
    }
}
