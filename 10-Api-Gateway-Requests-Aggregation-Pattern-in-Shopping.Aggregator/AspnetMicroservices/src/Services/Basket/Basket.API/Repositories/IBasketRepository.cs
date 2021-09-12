namespace Basket.API.Repositories
{
    using System.Threading.Tasks;
    using Basket.API.Entities;

    public interface IBasketRepository
    {
        Task<ShoppingCart> GetBasket(string userName);

        Task<ShoppingCart> UpdateBasket(ShoppingCart basket);

        Task DeleteBasket(string userName);
    }
}