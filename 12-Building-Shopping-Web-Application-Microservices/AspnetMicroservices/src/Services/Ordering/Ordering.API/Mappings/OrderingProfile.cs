namespace Ordering.API.Mappings
{
    using AutoMapper;
    using EventBus.Messages.Events;
    using Ordering.Application.Features.Orders.Commands.CheckoutOrder;

    public class OrderingProfile : Profile
    {
        public OrderingProfile()
        {
            CreateMap<CheckoutOrderCommand, BasketCheckoutEvent>().ReverseMap();
        }
    }
}