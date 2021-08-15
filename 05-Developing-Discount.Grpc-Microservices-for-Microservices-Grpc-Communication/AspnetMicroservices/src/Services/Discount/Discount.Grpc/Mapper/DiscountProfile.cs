namespace Discount.Grpc.Mapper
{
    using AutoMapper;
    using Discount.Grpc.Entities;
    using Discount.Grpc.Protos;

    public class DiscountProfile : Profile
    {
        public DiscountProfile()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}