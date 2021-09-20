namespace Shopping.Aggregator.Services
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Shopping.Aggregator.Extensions;
    using Shopping.Aggregator.Models;

    public class BasketService : IBasketService
    {
        private readonly HttpClient _client;

        public BasketService(HttpClient client)
        {
            _client = client ?? throw new System.ArgumentNullException(nameof(client));
        }

        public async Task<BasketModel> GetBasket(string userName)
        {
            var response = await _client.GetAsync($"/api/v1/Basket/{userName}");
            return await response.ReadContentAs<BasketModel>();
        }
    }
}