namespace Ordering.Application.Contracts.Persistence
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Ordering.Domain.Entities;

    public interface IOrderRepository : IAsyncRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}