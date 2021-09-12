namespace Ordering.Application.Features.Orders.Queries.GetOrdersList
{
    using System.Collections.Generic;
    using MediatR;

    public class GetOrdersListQuery : IRequest<List<OrdersVm>>
    {
        public GetOrdersListQuery(string userName)
        {
            UserName = userName ?? throw new System.ArgumentNullException(nameof(userName));
        }

        public string UserName { get; set; }
    }
}