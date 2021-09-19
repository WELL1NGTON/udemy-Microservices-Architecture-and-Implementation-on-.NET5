namespace Shopping.Aggregator.Services
{
    using System.Threading.Tasks;
    using Shopping.Aggregator.Models;

    public class BasketService : IBasketService
    {
        public Task<BasketModel> GetBasket(string userName)
        {
            throw new System.NotImplementedException();
        }
    }
}