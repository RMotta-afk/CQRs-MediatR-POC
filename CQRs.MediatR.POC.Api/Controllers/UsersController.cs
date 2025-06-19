using MediatR;
using Microsoft.AspNetCore.Mvc;
using CQRs.MediatR.POC.Domain.Users.Models;
using CQRs.MediatR.POC.Application.Users.Queries;
using CQRs.MediatR.POC.Application.Users.Commands;

namespace CQRs.MediatR.POC.Api.Controllers
{
    [ApiController]
    [Route("[users]")]
    public class UsersController : Controller
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("")]

        // An example of a command to create a user using Send and waiting for the result.
        public async Task<ActionResult<int>> CreateUser(CreateUserCommand command)
        {
            int userId = await _mediator.Send(command);

            return CreatedAtAction(nameof(CreateUser), new { id = userId }, userId);
        }

        [HttpGet("users/{userId}")]
        public async Task<ActionResult<User>> GetUser(GetUserQuery query)
        {
            var user = await _mediator.Send(query);

            return user;
        }
    }
}
