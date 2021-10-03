namespace AspnetRunBasics.Services
{
    using System.Threading.Tasks;
    using AspnetRunBasics.Models;

    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);

        Task<BasketModel> UpdateBasket(BasketModel model);

        Task CheckoutBasket(BasketCheckoutModel model);
    }
}
