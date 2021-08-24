namespace Ordering.Application.Features.Orders.Commands.DeleteOrder
{
    using MediatR;

    public class DeleteOrderCommand : IRequest
    {
        public int Id { get; set; }
    }
}