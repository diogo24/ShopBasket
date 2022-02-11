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
        public double Price { get; private set; }

        public Bread(double price)
        {
            Price = price;
        }
    }
}
