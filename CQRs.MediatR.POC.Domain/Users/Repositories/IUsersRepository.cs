
using CQRs.MediatR.POC.Domain.Users.Models;

namespace CQRs.MediatR.POC.Domain.Users.Repositories
{
    public interface IUsersRepository
    {
        Task<User> GetUserByIdAsync(Guid userId);

        Task<User> CreateUserAsync(string userName, string email);
    }
}
