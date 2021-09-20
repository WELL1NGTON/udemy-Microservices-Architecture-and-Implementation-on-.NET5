namespace Basket.API.Mapper
{
    using AutoMapper;
    using Basket.API.Entities;
    using EventBus.Messages.Events;

    public class BasketProfile : Profile
    {
        public BasketProfile()
        {
            CreateMap<BasketCheckout, BasketCheckoutEvent>().ReverseMap();
        }
    }
}