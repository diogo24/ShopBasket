using Shop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class OfferBread : IOffer
    {
        const decimal DiscountButterCount = 2;
        const decimal Discount50perc = 0.5m;

        public decimal GetDiscount(IEnumerable<IProduct> products)
        {
            var discount = 0m;
            var butterCount = products.Count(p => p.Id == Butter.ID);
            var breadCount  = products.Count(p => p.Id == Bread.ID);

            if (breadCount > 0 && butterCount > 1)
            {
                var discountPrice = products.First(p => p.Id == Bread.ID).Price * Discount50perc;

                var butterDifference = Math.Floor(butterCount / DiscountButterCount);
                var discountCount = Math.Min(breadCount, butterDifference);


                discount = Math.Round(discountPrice, 2) * discountCount;
            }

            return discount;
        }
    }
}
