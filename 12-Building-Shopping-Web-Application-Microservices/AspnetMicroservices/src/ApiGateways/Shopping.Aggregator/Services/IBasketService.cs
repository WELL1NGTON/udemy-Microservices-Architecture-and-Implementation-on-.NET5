namespace Shopping.Aggregator.Services
{
    using System.Threading.Tasks;
    using Shopping.Aggregator.Models;

    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);
    }
}