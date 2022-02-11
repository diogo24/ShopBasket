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
        public const int ID = 2;

        public int Id => ID;
        public decimal Price { get; private set; }

        public Butter(decimal price)
        {
            Price = price;
        }
    }
}
