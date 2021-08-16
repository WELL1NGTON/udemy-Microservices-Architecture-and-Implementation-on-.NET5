namespace Ordering.Application.Mappings
{
    using AutoMapper;
    using Ordering.Application.Features.Orders.Commands.CheckoutOrder;
    using Ordering.Application.Features.Orders.Commands.UpdateOrder;
    using Ordering.Application.Features.Orders.Queries.GetOrdersList;
    using Ordering.Domain.Entities;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrdersVm>().ReverseMap();
            CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();
        }
    }
}