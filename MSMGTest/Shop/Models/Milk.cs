using Shop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Milk : IProduct
    {
        public const int ID = 3;

        public int Id => ID;
        public decimal Price { get; private set; }

        public Milk(decimal price)
        {
            Price = price;
        }
    }
}
