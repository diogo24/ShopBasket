using Shop.Interfaces;

namespace Shop
{
    public class Basket
    {
        private IEnumerable<IOffer> Offers { get; }
        private IList<IProduct> Products { get; }

        public Basket(IEnumerable<IOffer> offers)
        {
            Offers = offers;
            Products = new List<IProduct>();
        }

        public void AddProduct(int quantity, IProduct product)
        {
            if (quantity > 0)
            {
                for (int i = 0; i < quantity; i++)
                {
                    Products.Add(product);
                }
            }
        }

        public double TotalAmount()
        {
            return Products.Sum(p => p.Price);
        }
    }
}