using Shop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class OfferMilk : IOffer
    {
        const decimal DiscountMilkCount = 4;

        public decimal GetDiscount(IEnumerable<IProduct> products)
        {
            var discount = 0m;
            var milkCount = products.Count(p => p.Id == Milk.ID);
            if (milkCount > 3)
            {
                var discountPrice = products.First(p => p.Id == Milk.ID).Price;

                var discountCount = Math.Floor(milkCount / DiscountMilkCount);

                discount = discountPrice * discountCount;
            }

            return discount;
        }
    }
}
