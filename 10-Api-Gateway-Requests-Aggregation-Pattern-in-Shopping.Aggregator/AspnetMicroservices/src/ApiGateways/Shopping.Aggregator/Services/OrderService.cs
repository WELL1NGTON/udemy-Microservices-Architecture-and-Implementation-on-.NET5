namespace Shopping.Aggregator.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Shopping.Aggregator.Models;

    public class OrderService : IOrderService
    {
        public Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName)
        {
            throw new System.NotImplementedException();
        }
    }
}