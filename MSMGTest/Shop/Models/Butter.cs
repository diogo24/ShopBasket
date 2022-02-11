using Shop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Butter : IProduct
    {
        public double Price { get; private set; }

        public Butter(double price)
        {
            Price = price;
        }
    }
}
