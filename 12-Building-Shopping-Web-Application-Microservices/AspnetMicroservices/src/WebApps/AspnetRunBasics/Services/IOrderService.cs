namespace AspnetRunBasics.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AspnetRunBasics.Models;

    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}
