using MediatR;
using CQRs.MediatR.POC.Domain.Users.Models;

namespace CQRs.MediatR.POC.Application.Users.Queries
{
    public class GetUserQuery : IRequest<User>
    {
    }
}
