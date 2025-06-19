using CQRs.MediatR.POC.Domain.Users.Models;
using CQRs.MediatR.POC.Domain.Users.Repositories;

namespace CQRs.MediatR.POC.Infra.Repositories.Users
{
    internal class UsersRepository : IUsersRepository
    {
        public Task<User> CreateUserAsync(string userName, string email)
        {
            return Task.FromResult(new User
            {
                Id = Guid.NewGuid(),
                Name = userName,
                Email = email
            });
        }

        public Task<User> GetUserByIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
