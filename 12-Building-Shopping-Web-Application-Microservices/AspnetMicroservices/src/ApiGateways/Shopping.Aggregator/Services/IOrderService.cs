namespace Shopping.Aggregator.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Shopping.Aggregator.Models;

    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}