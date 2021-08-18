namespace Basket.API.GrpcServices
{
    using System.Threading.Tasks;
    using Discount.Grpc.Protos;

    public class DiscountGrpcService
    {
        private readonly DiscountProtoService.DiscountProtoServiceClient _discountProtoService;

        public DiscountGrpcService(DiscountProtoService.DiscountProtoServiceClient discountProtoService)
        {
            _discountProtoService = discountProtoService;
        }

        public async Task<CouponModel> GetDiscount(string productName)
        {
            var discountRequest = new GetDiscountRequest { ProductName = productName, };

            return await _discountProtoService.GetDiscountAsync(discountRequest);
        }

        // public async Task
    }
}