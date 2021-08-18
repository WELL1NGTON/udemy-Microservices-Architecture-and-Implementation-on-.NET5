namespace Ordering.Infrastructure.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Ordering.Application.Contracts.Persistence;
    using Ordering.Domain.Entities;
    using Ordering.Infrastructure.Persistence;

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(OrderContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Order>> GetOrdersByUserName(string userName)
        {
            var orderList = await _dbContext.Orders
                                    .Where(o => o.UserName == userName)
                                    .ToListAsync();

            return orderList;
        }
    }
}