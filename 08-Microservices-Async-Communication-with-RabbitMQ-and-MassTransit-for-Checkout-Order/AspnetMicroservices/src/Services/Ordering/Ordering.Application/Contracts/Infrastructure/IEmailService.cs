namespace Ordering.Application.Contracts.Infrastructure
{
    using System.Threading.Tasks;
    using Ordering.Application.Models;

    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}